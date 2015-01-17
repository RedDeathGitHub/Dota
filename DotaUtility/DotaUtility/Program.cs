using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net.Mime;

using DotaUtility.Heroes;

namespace DotaUtility
{
	internal class Program
	{
		private const string InDirectory = "spellicons\\";
		private const string OutDirectory = "modifiedSpellicons\\";
		private const string OutTestDirectory = "test\\";
		private const string Extension = ".png";

		private const float FontSize = 22F;
		private const int PenWidth = 4;
		private static readonly Font Font = new Font("Comic Sans MS", FontSize, FontStyle.Bold, GraphicsUnit.Pixel);
		private static readonly Brush DefaultBrush = new SolidBrush(Color.White);
		private static readonly Pen DefaultPen = new Pen(Color.Black, PenWidth);

		private const int ImageSize = 128;
		private const int VerticalMargin = 4;
		private const int HorizontalMargin = 2;
		private const string Tab = "\t";

		private static void Main()
		{
			ProcessAllIcons();
		}

		private static void TestColor(Unit unit)
		{
			foreach (var ability in unit.Abilities)
			{
				foreach (var brushColor in (KnownColor[])Enum.GetValues(typeof(KnownColor)))
				{
					var brush = new SolidBrush(Color.FromKnownColor(brushColor));

					foreach (var penColor in (KnownColor[])Enum.GetValues(typeof(KnownColor)))
					{
						var pen = new Pen(Color.FromKnownColor(penColor), PenWidth);
						var suffix = " " + brushColor + " " + penColor;

						ProcessIcon(ability, ability.IconName, brush, pen, true, suffix);

						if (ability.AdditionalIconNames != null)
						{
							foreach (var alternativeName in ability.AdditionalIconNames)
							{
								ProcessIcon(ability, alternativeName, brush, pen, true, suffix);
							}
						}
					}
				}
			}
		}

		private static void ProcessAllIcons()
		{
			foreach (var hero in Units.All)
			{
				foreach (var ability in hero.Abilities)
				{
					ProcessIcon(ability);

					if (ability.AdditionalIconNames != null)
					{
						foreach (var alternativeName in ability.AdditionalIconNames)
						{
							ProcessIcon(ability, alternativeName);
						}
					}
				}
			}
		}

		private static void ProcessIcon(
			Ability ability,
			string alternativeName = null,
			Brush alternativeBrush = null,
			Pen alternativePen = null,
			bool test = false,
			string suffix = null)
		{
			var name = alternativeName ?? ability.IconName;
			var brush = alternativeBrush ?? DefaultBrush;
			var pen = alternativePen ?? DefaultPen;
			pen.LineJoin = LineJoin.Round;

			var image = new Bitmap(GetInPath(name));
			var graphics = Graphics.FromImage(image);

			// DrawBackground(graphics, ability);
			DrawText(graphics, ability, brush, pen);

			SaveImage(image, GetOutPath(name, test, suffix));
		}

		private static void SaveImage(Bitmap image, string path)
		{
			image.Save(path, ImageFormat.Png);
		}

		private static void DrawText(Graphics graphics, Ability ability, Brush brush, Pen pen)
		{
			var text = ability.Value;
			var rectangle = GetTextRectangle();
			var format = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};

			var path = new GraphicsPath();
			path.AddString(text, Font.FontFamily, (int)Font.Style, Font.Size, rectangle, format);

			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

			graphics.DrawPath(pen, path);
			graphics.FillPath(brush, path);
		}

		private static void DrawBackground(Graphics graphics, Ability ability)
		{
			var rectangle = GetBackgroundRectangle(graphics, ability);
			graphics.FillRectangle(Brushes.White, rectangle);
		}

		private static RectangleF GetTextRectangle()
		{
			return new RectangleF(0, 0, ImageSize, ImageSize);
		}

		private static RectangleF GetBackgroundRectangle(Graphics graphics, Ability ability)
		{
			var text = ability.Value.Replace(Tab, string.Empty);
			var size = graphics.MeasureString(text, Font);
			size.Width -= HorizontalMargin;
			size.Height -= VerticalMargin;

			var x = (ImageSize - size.Width) / 2;
			var y = (ImageSize - size.Height) / 2;
			var width = size.Width;
			var height = size.Height;
			return new RectangleF(x, y, width, height);
		}

		private static string GetInPath(string name)
		{
			return InDirectory + name + Extension;
		}

		private static string GetOutPath(string name, bool test, string suffix)
		{
			var directory = test ? OutTestDirectory : OutDirectory;

			return directory + name + suffix + Extension;
		}

		private static void tulisnamafile(string imagepath, string textnya)
		{
			float fontSize = 22;

			Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(imagepath)));
			//some test image for this demo
			Bitmap bmp = (Bitmap)Image.FromFile(imagepath);
			Graphics g = Graphics.FromImage(bmp);

			//this will center align our text at the bottom of the image
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Far;

			//define a font to use.
			Font f = new Font("Impact", fontSize, FontStyle.Bold, GraphicsUnit.Pixel);

			//pen for outline - set width parameter
			Pen p = new Pen(ColorTranslator.FromHtml("#77090C"), 8);
			p.LineJoin = LineJoin.Round; //prevent "spikes" at the path

			//this makes the gradient repeat for each text line
			Rectangle fr = new Rectangle(0, bmp.Height - f.Height, bmp.Width, f.Height);
			LinearGradientBrush b = new LinearGradientBrush(fr,
																											ColorTranslator.FromHtml("#FF6493"),
																											ColorTranslator.FromHtml("#D00F14"),
																											90);

			//this will be the rectangle used to draw and auto-wrap the text.
			//basically = image size
			Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);

			GraphicsPath gp = new GraphicsPath();

			//look mom! no pre-wrapping!
			gp.AddString(textnya, f.FontFamily, (int)FontStyle.Bold, fontSize, r, sf);

			//these affect lines such as those in paths. Textrenderhint doesn't affect
			//text in a path as it is converted to ..well, a path.
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.PixelOffsetMode = PixelOffsetMode.HighQuality;

			//TODO: shadow -> g.translate, fillpath once, remove translate
			g.DrawPath(p, gp);
			g.FillPath(b, gp);

			//cleanup
			gp.Dispose();
			b.Dispose();
			b.Dispose();
			f.Dispose();
			sf.Dispose();
			g.Dispose();
			string fileName = "ab.jpg";
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
			bmp.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
			bmp.Dispose();
		}
	}
}
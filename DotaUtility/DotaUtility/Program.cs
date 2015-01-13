using System;
using System.Drawing;
using System.Drawing.Imaging;

using DotaUtility.Heroes;

namespace DotaUtility
{
	internal class Program
	{
		private const string InDirectory = "spellicons\\";
		private const string OutDirectory = "modifiedSpellicons\\";
		private const string OutTestDirectory = "test\\";
		private const string Extension = ".png";

		private const float FontSize = 18F;
		private static readonly Font Font = new Font("Comic Sans MS", FontSize, FontStyle.Regular, GraphicsUnit.Pixel);

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
				foreach (var color in (KnownColor[])Enum.GetValues(typeof(KnownColor)))
				{
					var brush = new SolidBrush(Color.FromKnownColor(color));

					ProcessIcon(ability, ability.IconName, brush, true, color.ToString());

					if (ability.AdditionalIconNames != null)
					{
						foreach (var alternativeName in ability.AdditionalIconNames)
						{
							ProcessIcon(ability, alternativeName, brush, true, color.ToString());
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
			bool test = false,
			string suffix = null)
		{
			var name = alternativeName ?? ability.IconName;
			var brush = alternativeBrush ?? Brushes.Black;
			var image = new Bitmap(GetInPath(name));
			var graphics = Graphics.FromImage(image);

			DrawBackground(graphics, ability);
			DrawText(graphics, ability, brush);

			SaveImage(image, GetOutPath(name, test, suffix));
		}

		private static void SaveImage(Bitmap image, string path)
		{
			image.Save(path, ImageFormat.Png);
		}

		private static void DrawText(Graphics graphics, Ability ability, Brush brush)
		{
			var rectangle = GetTextRectangle();
			var format = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};

			graphics.DrawString(ability.Value, Font, brush, rectangle, format);
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
	}
}
using System.Drawing;
using System.Drawing.Imaging;

namespace DotaUtility
{
	internal class Program
	{
		private const string InDirectory = "spellicons\\";
		private const string OutDirectory = "modifiedSpellicons\\";
		private const string Extension = ".png";

		private const float FontSize = 19F;
		private static readonly Font Font = new Font("Comic Sans MS", FontSize, FontStyle.Regular, GraphicsUnit.Pixel);

		private const int ImageSize = 128;
		private const string Tab = "\t";

		private static void Main()
		{
			foreach (var hero in Units.All)
			{
				foreach (var ability in hero.Abilities)
				{
					ProcessImage(ability);

					if (ability.AdditionalIconNames != null)
					{
						foreach (var alternativeName in ability.AdditionalIconNames)
						{
							ProcessImage(ability, alternativeName);
						}
					}
				}
			}
		}

		private static void ProcessImage(Ability ability, string alternativeName = null)
		{
			var name = alternativeName ?? ability.IconName;

			var image = new Bitmap(GetInPath(name));
			var graphics = Graphics.FromImage(image);

			DrawRectangle(graphics, ability);
			DrawText(graphics, ability);
			SaveImage(image, GetOutPath(name));
		}

		private static void SaveImage(Bitmap image, string path)
		{
			image.Save(path, ImageFormat.Png);
		}

		private static void DrawText(Graphics graphics, Ability ability)
		{
			var position = GetPosition();
			var format = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};

			graphics.DrawString(ability.Value, Font, Brushes.Black, position, format);
		}

		private static void DrawRectangle(Graphics graphics, Ability ability)
		{
			var rectangle = GetRectangle(graphics, ability);
			graphics.FillRectangle(Brushes.White, rectangle);
		}

		private static RectangleF GetPosition()
		{
			return new RectangleF(0, 0, ImageSize, ImageSize);
		}

		private static RectangleF GetRectangle(Graphics graphics, Ability ability)
		{
			var text = ability.Value.Replace(Tab, string.Empty);
			var size = graphics.MeasureString(text, Font);

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

		private static string GetOutPath(string name)
		{
			return OutDirectory + name + Extension;
		}
	}
}
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
		private const int LeftMargin = 2;
		private const int RightMargin = 2;
		private const int PassiveTopMargin = 5;
		private const int PassiveRightMargin = 10;
		private const string Tab = "\t";

		private static void Main()
		{
			foreach (var hero in UnitCollection.All)
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
			var position = GetPosition(ability.Passive);
			var format = new StringFormat { Alignment = StringAlignment.Far };
			graphics.DrawString(ability.Value, Font, Brushes.Black, position, format);
		}

		private static void DrawRectangle(Graphics graphics, Ability ability)
		{
			var rectangle = GetRectangle(graphics, ability);
			graphics.FillRectangle(Brushes.White, rectangle);
		}

		private static RectangleF GetPosition(bool passive)
		{
			var rightMargin = GetRightMargin(passive);
			var width = ImageSize - rightMargin;
			var y = passive ? PassiveTopMargin : 0;
			return new RectangleF(0, y, width, ImageSize);
		}

		private static RectangleF GetRectangle(Graphics graphics, Ability ability)
		{
			var text = ability.Value.Replace(Tab, string.Empty);
			var size = graphics.MeasureString(text, Font);
			var margin = GetMargin(ability.Passive);

			var x = ImageSize - size.Width - margin;
			var width = size.Width + margin;
			var height = ability.Passive ? size.Height + PassiveTopMargin : size.Height;
			return new RectangleF(x, 0, width, height);
		}

		private static int GetMargin(bool passive)
		{
			var margin = RightMargin + LeftMargin;
			if (passive)
			{
				margin += PassiveRightMargin;
			}
			return margin;
		}

		private static int GetRightMargin(bool passive)
		{
			var margin = RightMargin;
			if (passive)
			{
				margin += PassiveRightMargin;
			}
			return margin;
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
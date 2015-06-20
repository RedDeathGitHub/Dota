using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;

namespace DotaUtility
{
    internal class Program
    {
        private const string InDirectory = "spellicons\\";
        private const string OutDirectory = "modifiedSpellicons\\";
        private const string OutTestDirectory = "test\\";
        private const string Extension = ".png";

        private const float FontSize = 20F;
        private const int PenWidth = 4;
        private static readonly Font Font = new Font("Comic Sans MS", FontSize, FontStyle.Bold, GraphicsUnit.Pixel);
        private static readonly Brush DefaultBrush = new SolidBrush(Color.White);
        private static readonly Pen DefaultPen = new Pen(Color.Black, PenWidth);
        private const int ImageSize = 128;

        private static void Main()
        {
            ProcessAllIcons();
        }

        private static void ProcessAllIcons()
        {
            foreach (var ability in Units.All.SelectMany(hero => hero.Abilities))
            {
                ProcessIcon(ability);
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
            foreach (var iconName in ability.IconNames)
            {
                var brush = alternativeBrush ?? DefaultBrush;
                var pen = alternativePen ?? DefaultPen;
                pen.LineJoin = LineJoin.Round;

                var image = new Bitmap(GetInPath(iconName));
                var graphics = Graphics.FromImage(image);

                DrawText(graphics, ability, brush, pen);

                SaveImage(image, GetOutPath(iconName, test, suffix));
            }
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

        private static RectangleF GetTextRectangle()
        {
            return new RectangleF(0, 0, ImageSize, ImageSize);
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
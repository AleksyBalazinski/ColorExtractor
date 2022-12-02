namespace ColorExtractor
{
    // RGB value, where each component is in [0-255]
    internal struct RGB
    {
        public int r;
        public int g;
        public int b;
        public RGB(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public static RGB operator *(double c, RGB color)
        {
            return new RGB((int)(c * color.r), (int)(c * color.g), (int)(c * color.b));
        }

        public static RGB operator +(RGB color1, RGB color2)
        {
            return new RGB(color1.r + color2.r, color1.g + color2.g, color1.b + color2.b);
        }

        public static RGB operator -(RGB color1, RGB color2)
        {
            return new RGB(color1.r - color2.r, color1.g - color2.g, color1.b - color2.b);
        }

        public static implicit operator Color(RGB color)
        {
            return Color.FromArgb(color.r, color.g, color.b);
        }
    }
}

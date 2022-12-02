namespace ColorExtractor
{
    internal class HSVSeparator : ISeparator
    {
        public (RGB, RGB, RGB) Separate(Color color, PresentationMode mode)
        {
            var (h, s, v) = Converters.RGB2HSV(color.R / 255.0, color.G / 255.0, color.B / 255.0);
            RGB channel1 = new((int)(h * 255 / 360.0), (int)(h * 255 / 360.0), (int)(h * 255 / 360.0));
            RGB channel2 = new((int)(s * 255), (int)(s * 255), (int)(s * 255));
            RGB channel3 = new((int)(v * 255), (int)(v * 255), (int)(v * 255));

            return (channel1, channel2, channel3);
        }
    }
}

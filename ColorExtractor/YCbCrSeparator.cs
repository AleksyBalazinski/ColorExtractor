namespace ColorExtractor
{
    internal class YCbCrSeparator : ISeparator
    {
        public (RGB, RGB, RGB) Separate(Color color, PresentationMode mode)
        {
            var (y, cb, cr) = Converters.RGB2YCbCr(color.R / 255.0, color.G / 255.0, color.B / 255.0);

            RGB channel1 = new((int)(y * 255), (int)(y * 255), (int)(y * 255));
            RGB channel2;
            RGB channel3;
            if (mode == PresentationMode.Color)
            {
                channel2 = Utility.Interpolate(cb, new RGB(127, 255, 0), new RGB(127, 0, 255));
                channel3 = Utility.Interpolate(cr, new RGB(0, 255, 127), new RGB(255, 0, 127));
            }
            else if (mode == PresentationMode.GrayScale)
            {
                channel2 = new((int)(cb * 255), (int)(cb * 255), (int)(cb * 255));
                channel3 = new((int)(cr * 255), (int)(cr * 255), (int)(cr * 255));
            }
            else
            {
                throw new NotSupportedException();
            }


            return (channel1, channel2, channel3);
        }
    }
}

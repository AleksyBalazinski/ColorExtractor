namespace ColorExtractor
{
    internal class LabSeparator : ISeparator
    {
        readonly RGBColorSpace colorSpace;
        public LabSeparator(RGBColorSpace colorSpace)
        {
            this.colorSpace = colorSpace;
        }

        public (RGB, RGB, RGB) Separate(Color color, PresentationMode mode)
        {
            var (X, Y, Z) = Converters.RGB2XYZ(colorSpace, color.R / 255.0, color.G / 255.0, color.B / 255.0);
            double Xr = 100 / colorSpace.yw * colorSpace.xw;
            double Yr = 100;
            double Zr = 100 / colorSpace.yw * (1 - colorSpace.xw - colorSpace.yw);
            var (L, a, b) = Converters.XYZ2LAB(X * 100, Y * 100, Z * 100, Xr, Yr, Zr);

            int LCropped = (int)L;
            if (LCropped > 100)
            {
                throw new Exception("something terrible happend");
            }

            RGB channel1 = new((int)(LCropped * 255 / 100.0), (int)(LCropped * 255 / 100.0), (int)(LCropped * 255 / 100.0));
            double aCropped = a + 128;
            if (aCropped < 0)
                aCropped = 0;
            if (aCropped > 255)
                aCropped = 255;

            double bCropped = b + 128;
            if (bCropped < 0)
                bCropped = 0;
            if (bCropped > 255)
                bCropped = 255;

            RGB channel2;
            RGB channel3;
            if (mode == PresentationMode.Color)
            {
                channel2 = Utility.Interpolate(aCropped / 255, new RGB(0, 255, 127), new RGB(255, 0, 127));
                channel3 = Utility.Interpolate(bCropped / 255, new RGB(0, 127, 255), new RGB(255, 127, 0));
            }
            else if (mode == PresentationMode.GrayScale)
            {
                channel2 = new((int)aCropped, (int)aCropped, (int)aCropped);
                channel3 = new((int)bCropped, (int)bCropped, (int)bCropped);
            }
            else
            {
                throw new NotSupportedException();
            }

            return (channel1, channel2, channel3);
        }
    }
}

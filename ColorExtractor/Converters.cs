namespace ColorExtractor
{
    internal static class Converters
    {
        /// <summary>
        /// Converts from CIEXYZ to CIELAB color spaces. X, Y, Z values must be normalized to reference white Yr = 100
        /// </summary>
        /// <param name="X">tristimulus value X</param>
        /// <param name="Y">tristimulus value Y</param>
        /// <param name="Z">tristimulus value Z</param>
        /// <param name="Xr">reference illuminant</param>
        /// <param name="Yr">reference illuminant</param>
        /// <param name="Zr">reference illuminant</param>
        /// <returns></returns>
        public static (double, double, double) XYZ2LAB(double X, double Y, double Z, double Xr, double Yr, double Zr)
        {
            double L;
            if (Y / Yr > 0.008856)
                L = 116 * Math.Pow(Y / Yr, 1.0 / 3) - 16;
            else
                L = 903.3 * Y / Yr;

            double px = X / Xr >= 0 ? Math.Pow(X / Xr, 1.0 / 3) : (-1) * Math.Pow((-1) * X / Xr, 1.0 / 3);
            double py = Y / Yr >= 0 ? Math.Pow(Y / Yr, 1.0 / 3) : (-1) * Math.Pow((-1) * Y / Yr, 1.0 / 3);
            double pz = Z / Zr >= 0 ? Math.Pow(Z / Zr, 1.0 / 3) : (-1) * Math.Pow((-1) * Z / Zr, 1.0 / 3);

            double a = 500 * (px - py);

            double b = 200 * (py - pz);

            return (L, a, b);
        }

        /// <summary>
        /// Converts from RGB to YCbCr
        /// </summary>
        /// <param name="R">red in [0,1]</param>
        /// <param name="G">green in [0,1]</param>
        /// <param name="B">blue in [0,1]</param>
        /// <returns>Y, Cb, Cr values each in [0,1] range</returns>
        public static (double, double, double) RGB2YCbCr(double R, double G, double B)
        {
            double Y = 0.299 * R + 0.587 * G + 0.114 * B;
            double Cb = (B - Y) / 1.772 + 0.5;
            double Cr = (R - Y) / 1.402 + 0.5;

            return (Y, Cb, Cr);
        }

        /// <summary>
        /// Converts from RGB to HSV
        /// </summary>
        /// <param name="R">red in range [0,1]</param>
        /// <param name="G">green in range [0,1]</param>
        /// <param name="B">blue in range [0,1]</param>
        /// <returns>H (in degrees) in [0,360], S in [0,1] V in [0,1]</returns>
        public static (double, double, double) RGB2HSV(double R, double G, double B)
        {
            double max = Math.Max(R, Math.Max(G, B));
            double min = Math.Min(R, Math.Min(G, B));
            double v = max;
            double c = max - min;
            double s = v == 0 ? 0 : c / v;

            double h;
            if (c == 0)
                h = 0;
            else if (v == R)
                h = (G - B) / c;
            else if (v == G)
                h = 2 + (B - R) / c;
            else if (v == B)
                h = 4 + (B - G) / c;
            else
                h = 0; // silence warnings

            if (h >= 0)
                h %= 6;
            else
                h = h % 6 + 6;

            return (h * 60, s, v);
        }

        /// <summary>
        /// Converts from arbitrary RGB color space to CIE XYZ
        /// </summary>
        /// <param name="colorSpace">RGB color space</param>
        /// <param name="R">red value in the given color space in range [0,1]</param>
        /// <param name="G">green value in the given color space in range [0,1]</param>
        /// <param name="B">blue value in the given color space in range [0,1]</param>
        /// <returns>tristimulus values X, Y, Z normalized s.t. Y is less or equal to 1</returns>
        public static (double, double, double) RGB2XYZ(RGBColorSpace colorSpace, double R, double G, double B)
        {
            double[] colorLin = Utility.GammaCorrection(R, G, B, colorSpace.gamma);
            double[] XYZ = Utility.Mul(colorSpace.conversionMatrix, colorLin);

            return (XYZ[0], XYZ[1], XYZ[2]);
        }
    }
}

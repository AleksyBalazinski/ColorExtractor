namespace ColorExtractor
{
    internal class RGBColorSpace
    {
        public double xr, yr, xg, yg, xb, yb; // reg, green and blue primaries
        public double xw, yw; // white point
        public double gamma; // gamma correction value
        public double[,] conversionMatrix; // conversion matrix to CIE XYZ

        public RGBColorSpace(double xr, double yr, double xg, double yg, double xb, double yb, double xw, double yw, double gamma)
        {
            this.xr = xr; this.yr = yr; this.xg = xg;
            this.yg = yg; this.xb = xb; this.yb = yb;
            this.xw = xw; this.yw = yw;
            this.gamma = gamma;
            conversionMatrix = CalculateConversionMatrix();
        }

        private double[,] CalculateConversionMatrix()
        {
            double Yw = 1;
            double Xw = xw * Yw / yw;
            double Zw = (1 - xw - yw) * (Yw / yw);
            double zr = 1 - xr - yr, zg = 1 - xg - yg, zb = 1 - xb - yb;

            double[,] M = new double[3, 3]
                {
                    { xr, xg, xb },
                    { yr, yg, yb },
                    { zr, zg, zb }
                };
            double[] W = new double[3] { Xw, Yw, Zw };
            var invM = Utility.Inv3x3(M);
            var S = Utility.Mul(invM, W);

            double Sr = S[0], Sg = S[1], Sb = S[2];

            return new double[3, 3]
            {
                { xr * Sr, xg * Sg, xb * Sb },
                { yr * Sr, yg * Sg, yb * Sb },
                { zr * Sr, zg * Sg, zb * Sb }
            };
        }
    }
}

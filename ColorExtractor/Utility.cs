namespace ColorExtractor
{
    internal static class Utility
    {
        // each component is assuemd to be in range [0, 1]
        public static double[] GammaCorrection(double r, double g, double b, double gamma)
        {
            return new double[3] { Math.Pow(r, gamma), Math.Pow(g, gamma), Math.Pow(b, gamma) };
        }

        public static double[,] Inv3x3(double[,] m)
        {
            var mInv = new double[3, 3];
            double det = Det3x3(m);
            if (det == 0)
                throw new InvalidOperationException("Matrix doesn't have an inverse");

            double invDet = 1 / det;
            mInv[0, 0] = (m[1, 1] * m[2, 2] - m[2, 1] * m[1, 2]) * invDet;
            mInv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) * invDet;
            mInv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) * invDet;
            mInv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) * invDet;
            mInv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) * invDet;
            mInv[1, 2] = (m[1, 0] * m[0, 2] - m[0, 0] * m[1, 2]) * invDet;
            mInv[2, 0] = (m[1, 0] * m[2, 1] - m[2, 0] * m[1, 1]) * invDet;
            mInv[2, 1] = (m[2, 0] * m[0, 1] - m[0, 0] * m[2, 1]) * invDet;
            mInv[2, 2] = (m[0, 0] * m[1, 1] - m[1, 0] * m[0, 1]) * invDet;

            return mInv;
        }

        // calculates determinant of a 3x3 matrix
        public static double Det3x3(double[,] m)
        {
            double det = m[0, 0] * (m[1, 1] * m[2, 2] - m[2, 1] * m[1, 2]) -
             m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
             m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

            return det;
        }

        // multiplies vector by matrix
        public static double[] Mul(double[,] m, double[] v)
        {
            double[] mv = new double[m.GetLength(1)];
            for (int i = 0; i < m.GetLength(1); i++)
            {
                for (int j = 0; j < v.Length; j++)
                {
                    mv[i] += m[i, j] * v[j];
                }
            }

            return mv;
        }

        public static RGB Interpolate(double t, RGB a, RGB b)
        {
            int red = (int)(a.r + (b.r - a.r) * t);
            int green = (int)(a.g + (b.g - a.g) * t);
            int blue = (int)(a.b + (b.b - a.b) * t);

            return new RGB(red, green, blue);
        }
    }
}

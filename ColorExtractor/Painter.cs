using ColorExtractor.Separators;

namespace ColorExtractor
{
    internal class Painter
    {
        public static void Paint(Bitmap bitmap, Bitmap resBitmap1, Bitmap resBitmap2, Bitmap resBitmap3, ISeparator separator, int imageHeight, int imageWidth, PresentationMode mode)
        {
            using (Graphics gfx = Graphics.FromImage(resBitmap1))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                gfx.FillRectangle(brush, 0, 0, resBitmap1.Width, resBitmap1.Height);
            }
            using (Graphics gfx = Graphics.FromImage(resBitmap2))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                gfx.FillRectangle(brush, 0, 0, resBitmap2.Width, resBitmap2.Height);
            }
            using (Graphics gfx = Graphics.FromImage(resBitmap3))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                gfx.FillRectangle(brush, 0, 0, resBitmap3.Width, resBitmap3.Height);
            }

            double scale;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    var (col1, col2, col3) = separator.Separate(color, mode);

                    int maxDim = Math.Max(imageWidth, imageHeight);
                    int minBmp = Math.Min(resBitmap1.Width, resBitmap1.Height);
                    if (maxDim > minBmp)
                        scale = (double)minBmp / maxDim;
                    else
                        scale = 1;

                    resBitmap1.SetPixel((int)(x * scale), (int)(y * scale), col1);

                    resBitmap2.SetPixel((int)(x * scale), (int)(y * scale), col2);

                    resBitmap3.SetPixel((int)(x * scale), (int)(y * scale), col3);
                }
            }
        }
    }
}

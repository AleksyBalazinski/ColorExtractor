namespace ColorExtractor
{
    internal class Painter
    {
        public static void Paint(Bitmap bitmap, Bitmap resBitmap1, Bitmap resBitmap2, Bitmap resBitmap3, ISeparator separator, int imageHeight, int imageWidth, PresentationMode mode)
        {
            double scale;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    var (col1, col2, col3) = separator.Separate(color, mode);

                    int maxDim = Math.Max(imageWidth, imageHeight);
                    if (maxDim > resBitmap1.Height)
                        scale = (double)resBitmap1.Height / maxDim;
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

namespace ColorExtractor
{
    internal interface ISeparator
    {
        (RGB, RGB, RGB) Separate(Color color, PresentationMode mode);
    }
}

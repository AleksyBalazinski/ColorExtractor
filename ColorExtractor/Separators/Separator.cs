namespace ColorExtractor.Separators
{
    internal interface ISeparator
    {
        (RGB, RGB, RGB) Separate(Color color, PresentationMode mode);
    }
}

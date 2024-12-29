namespace Shawsoft.Razor.UI.Utilities
{
    public static class FileHelpers
    {
        public static string FormatFileSize(long sizeInBytes)
        {
            const long OneKB = 1024;
            const long OneMB = OneKB * 1024;

            return sizeInBytes < OneMB
                ? $"{(sizeInBytes / (float)OneKB):n2} KB"
                : $"{(sizeInBytes / (float)OneMB):n2} MB";
        }
    }
}

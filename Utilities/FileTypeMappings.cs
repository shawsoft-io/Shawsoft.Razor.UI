using Shawsoft.Razor.UI.Enums;

namespace Shawsoft.Razor.UI.Utilities
{
    public static class FileTypeMappings
    {
        private static readonly Dictionary<FileTypes, List<string>> MimeTypeMap = new()
        {
            { FileTypes.Pdf, new List<string> { "application/pdf" } },
            { FileTypes.Image, new List<string> { "image/jpeg", "image/png", "image/gif", "image/bmp" } },
            { FileTypes.PowerPoint, new List<string> { "application/vnd.openxmlformats-officedocument.presentationml.presentation" } },
            { FileTypes.Word, new List<string> { "application/vnd.openxmlformats-officedocument.wordprocessingml.document" } },
            { FileTypes.Excel, new List<string> { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" } }
        };

        public static List<string>? GetMimeTypes(FileTypes fileType)
        {
            return MimeTypeMap.TryGetValue(fileType, out var mimeTypes) ? mimeTypes : null;
        }

        public static string GetFileType(string mimeType) =>
            MimeTypeMap
                .FirstOrDefault(kvp => kvp.Value.Contains(mimeType)).Key.ToString() ?? "other";


        public static bool IsSupportedMimeType(string mimeType, FileTypes[] allowedFileTypes)
        {
            var allowedMimeTypes = allowedFileTypes
                .SelectMany(fileType => GetMimeTypes(fileType) ?? [])
                .ToList();

            return allowedMimeTypes.Contains(mimeType);
        }
    }
}

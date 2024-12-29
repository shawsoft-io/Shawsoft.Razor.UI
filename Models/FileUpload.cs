namespace Shawsoft.Razor.UI.Models
{
    public class FileUpload
    {
        public string FileName { get; set; }

        public string ContentType { get; set; }

        public byte[] Data { get; set; }

        public FileUpload(string fileName, string contentType, byte[] data)
        { 
            FileName = fileName;
            ContentType = contentType;
            Data = data;
        }
    }
}

namespace MyApp.Application.Core.Models
{
    public class MailAttachment
    {
        public byte[] Data { get; set; }
        public string Filename { get; set; }
        public string MediaType { get; set; }

        public MailAttachment(byte[] data, string filename, string mediaType)
        {
            Data = data;
            Filename = filename;
            MediaType = mediaType;
        }
    }
}

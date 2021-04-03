namespace Handyman.Service.Handler.Common.Info
{
    public class PartDocumentInfo
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Source { get; set; }
        public bool Active { get; set; }
    }
}

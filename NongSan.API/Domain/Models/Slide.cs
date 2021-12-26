namespace NongSan.API.Domain.Models
{
    public class Slide : Base
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public string Status { get; set; }

    }
}

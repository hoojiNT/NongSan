namespace NongSan.API.Domain.Models
{
    public class Menu : Base
    {
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public string Status { get; set; }
        public int ParentID { get; set; }
        public string MenutypeID { get; set; }

        public virtual MenuType MenuType { get; set; }

    }
}

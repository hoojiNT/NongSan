using NongSan.API.Domain.Models;
namespace NongSan.API.DTOs
{
    public class MenuDTO: Base
    {
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public string Status { get; set; }
        public int ParentID { get; set; }
        public string MenutypeID { get; set; }
    }
}

using NongSan.API.Domain.Models;

namespace NongSan.API.DTOs
{
    public class CategoryDTO:Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

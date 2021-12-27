using AutoMapper;
using NongSan.API.DTOs;
using NongSan.API.Domain.Models;

namespace NongSan.API.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //map supplier
            CreateMap<Supplier, SupplierDTO>().ReverseMap();
            //map category
            CreateMap<Category, CategoryDTO>().ReverseMap();
            //map order
            CreateMap<Order, OrderDTO>().ReverseMap();
            //map OrderDetail
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            //map Product
            CreateMap<Product, ProductDTO>().ReverseMap();
            //map category
            CreateMap<Category, CategoryDTO>().ReverseMap();
            //map contact
            CreateMap<Contact, ContactDTO>().ReverseMap();
            //map menu
            CreateMap<Menu, MenuDTO>().ReverseMap();
            //map ProductImage
            CreateMap<ProductImage, ProductImageDTO>().ReverseMap();
            //map ShoppingCart
            CreateMap<ShoppingCart, ShoppingCartDTO>().ReverseMap();
        }
    }
}
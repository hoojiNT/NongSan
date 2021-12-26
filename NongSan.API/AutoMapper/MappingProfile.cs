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
            CreateMap<Supplier, SupplierDTO>();
            CreateMap<SupplierDTO, Supplier>();
            //map category
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            //map order
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            //map OrderDetail
            CreateMap<OrderDetail, OrderDetailDTO>();
            CreateMap<OrderDetailDTO, OrderDetail>();
            //map Product
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            //map category
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            //map contact
            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();   
            //map menu
            CreateMap<Menu, MenuDTO>();
            CreateMap<MenuDTO, Menu>(); 
            //map ProductImage
            CreateMap<ProductImage, ProductImageDTO>();
            CreateMap<ProductImageDTO, ProductImage>();
            //map ShoppingCart
            CreateMap<ShoppingCart, ShoppingCartDTO>();
            CreateMap<ShoppingCartDTO, ShoppingCart>();
        }
    }
}
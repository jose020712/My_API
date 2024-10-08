﻿using AutoMapper;
using MiApi.DTOs;
using MiApi.Models;

namespace MiApi.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Mapper Product
            CreateMap<ProductInsertDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductDto>();

            //Mapper Category
            CreateMap<CategoryInsertDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryDto>();

            //Mapper Warehose
            CreateMap<WarehouseInsertDto, Warehouse>();
            CreateMap<WarehouseUpdateDto, Warehouse>();
            CreateMap<Warehouse, WarehouseDto>();

            //Mapper User
            CreateMap<UserUpdateDto, User>();
            CreateMap<UserInsertDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, UserUpdateDto>();
        }
    }
}

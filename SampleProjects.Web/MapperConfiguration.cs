using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;

namespace SampleProjects.Web
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateConfigMaps();
        }
        protected virtual void CreateConfigMaps()
        {
            CreateMap<Category, CategoryModel>();

            //CreateMap<Category, CategoryMoedl>().ReverseMap();


            CreateMap<CategoryModel, Category>();
            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<PictureBinary, PictureBinaryModel>();
            CreateMap<PictureBinaryModel, PictureBinary>();
            CreateMap<Unit, UnitModel>();
            CreateMap<UnitModel, Unit>();
            CreateMap<City, CityModel>().ReverseMap();
            CreateMap<Picture, PictureModel>().ReverseMap();
            CreateMap<StateProvince, StateProvinceModel>().ReverseMap();
            CreateMap<Customer, CustomerModel>().ReverseMap();
        }
    }
}

using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;

namespace SampleProjects.Web
{
    public class MapperConfiguration : Profile
    {
        //public MapperConfiguration()
        //{
        //    CreateConfigMaps();
        //}
        protected virtual void CreateConfigMaps()
        {
            CreateMap<Category, CategoryMoedl>();

            //CreateMap<Category, CategoryMoedl>().ReverseMap();


            CreateMap<CategoryMoedl, Category>();
            CreateMap<PictureBinary, PictureBinaryModel>();
            CreateMap<PictureBinaryModel, PictureBinary>();
            CreateMap<Unit, UnitModel>();
            CreateMap<UnitModel, Unit>();
        }
    }
}

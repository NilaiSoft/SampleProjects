using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SampleProjects.Models;
using SampleProjects.Models.ViewModels;

namespace SampleProjects.Web
{
    public class MapperConfiguration : Profile
    {
        protected virtual void CreateConfigMaps()
        {
            CreateMap<Category, CategoryMoedl>();
        }
    }
}

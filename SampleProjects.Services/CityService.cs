namespace SampleProjects.Services
{
    public class CityService : Repository<City, CityModel>, ICityService
    {
        public CityService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

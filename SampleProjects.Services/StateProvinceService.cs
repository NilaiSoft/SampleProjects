namespace SampleProjects.Services
{
    public class StateProvinceService : Repository<StateProvince, StateProvinceModel>, IStateProvinceService
    {
        public StateProvinceService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

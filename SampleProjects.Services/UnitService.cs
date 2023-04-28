namespace SampleProjects.Services
{
    public class UnitService : Repository<Unit, UnitModel>, IUnitService
    {
        public UnitService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

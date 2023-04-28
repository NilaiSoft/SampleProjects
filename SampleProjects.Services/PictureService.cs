namespace SampleProjects.Services
{
    public class PictureService : Repository<Picture, PictureModel>, IPictureService
    {
        public PictureService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

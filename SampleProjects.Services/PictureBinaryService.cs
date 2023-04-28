namespace SampleProjects.Services
{
    public class PictureBinaryService : Repository<PictureBinary, PictureBinaryModel>, IPictureBinaryService
    {
        public PictureBinaryService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

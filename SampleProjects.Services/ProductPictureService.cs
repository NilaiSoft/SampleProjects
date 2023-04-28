namespace SampleProjects.Services
{
    public class ProductPictureService : Repository<ProductPicture, ProductPictureModel>, IProductPictureService
    {
        public ProductPictureService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

namespace SampleProjects.Services
{
    public class ProductCategoryService : Repository<ProductCategory, ProductCategoryModel>, IProductCategoryService
    {
        public ProductCategoryService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

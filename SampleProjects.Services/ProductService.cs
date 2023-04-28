namespace SampleProjects.Services
{
    public class ProductService : Repository<Product, ProductModel>, IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

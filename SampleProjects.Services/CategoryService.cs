namespace SampleProjects.Services
{
    public class CategoryService : Repository<Category, CategoryModel>, ICategoryService
    {
        public CategoryService(ApplicationDbContext context) : base(context)
        {

        }
    }
}

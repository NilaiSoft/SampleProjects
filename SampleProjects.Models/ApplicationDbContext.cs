using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace SampleProjects.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //_transaction = Database.BeginTransaction();
        }

        public ApplicationDbContext() : base()
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PictureBinary> PictureBinaries { get; set; }
        public virtual DbSet<ProductPicture> ProductPictures { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public async Task<int> CommitAsync()
        {
            try
            {
                var result = await SaveChangesAsync();
                //_transaction.Commit();
                return result;
            }
            catch
            {
                //await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                return 0;
            }
        }
    }
}

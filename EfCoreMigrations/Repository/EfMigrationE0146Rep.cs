using EfCoreMigrations.Data;
using EfCoreMigrations.IRepository;

namespace EfCoreMigrations.Repository
{
    public class EfMigrationE0146Rep:IEfMigrationE0146Rep
    {
        AppDbContext dbContext { get; set; }
        public EfMigrationE0146Rep ( AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<bool> EfMigrationsSave(EfCoreMigrations.Entity.EfMigrationE0146 efMigrationE0146)
        {
            try
            {
                dbContext.EfMigrationE0146.Add(efMigrationE0146);
                var rowsAffected = await dbContext.SaveChangesAsync();
                return rowsAffected >= 1 ? true : false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

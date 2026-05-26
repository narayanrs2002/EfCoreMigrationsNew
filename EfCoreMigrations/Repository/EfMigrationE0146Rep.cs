using EfCoreMigrations.Data;
using EfCoreMigrations.IRepository;

namespace EfCoreMigrations.Repository
{
    public class EfMigrationE0146Rep:IEfMigrationE0146Rep
    {
        //Comment testing
        AppDbContext dbContext { get; set; }//Comment Random on an existing line

        public EfMigrationE0146Rep ( AppDbContext dbContextConstruct)
        {
            dbContext = dbContextConstruct;
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

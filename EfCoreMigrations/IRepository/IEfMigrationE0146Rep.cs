
using EfCoreMigrations.Entity;

namespace EfCoreMigrations.IRepository
{
    public interface IEfMigrationE0146Rep
    {
        public Task<bool> EfMigrationsSave(EfMigrationE0146 efMigrationE0146);
    }
}

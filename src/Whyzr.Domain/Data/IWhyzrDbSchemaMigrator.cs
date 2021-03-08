using System.Threading.Tasks;

namespace Whyzr.Data
{
    public interface IWhyzrDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

using System.Data.Entity;

namespace Proje.API
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
        }
        public DataContext(string connectionString) : base(connectionString)
        {
        }
        public virtual DbSet<Users> Users { get; set; }
    }
    
}

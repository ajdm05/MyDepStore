using System.Data.Entity;

namespace MyDepStore.Database.Model
{
    public class MyDepStoreContext : DbContext
    {

        public MyDepStoreContext() : base ("name = MyDepStore")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}

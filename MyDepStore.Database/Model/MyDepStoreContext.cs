using System.Data.Entity;

namespace MyDepStore.Database.Model
{
    public class MyDepStoreContext : DbContext
    {

        public MyDepStoreContext() : base (nameOrConnectionString : "MyDepStoreContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Privilege> Privileges { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            System.Data.Entity.Database.SetInitializer<MyDepStoreContext>(null);

            // Many-to-Many RelationShips
            modelBuilder.Entity<Privilege>().HasMany(x => x.Roles).WithMany(x => x.Privileges)
                .Map(m =>
                {
                    m.ToTable("ROLES_PRIVILEGES");
                    m.MapLeftKey("PRIVILEGE_ID");
                    m.MapRightKey("ROLE_ID");
                });

            // Privilege -> PRIVILEGES
            modelBuilder.Entity<Privilege>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Privilege>()
                .Property(e => e.Description)
                .IsUnicode(false);

            // Role -> ROLES
            modelBuilder.Entity<Role>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Description)
                .IsUnicode(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}

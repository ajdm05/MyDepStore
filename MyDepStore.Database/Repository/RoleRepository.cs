using MyDepStore.Database.Model;
using System;
using System.Linq;

namespace MyDepStore.Database.Repository
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(MyDepStoreContext context) : base (context)
        {
        }

        public override IQueryable<Role> All()
        {
            return this.Context.Roles;
        }

        protected override Role MapNewValuesToOld(Role oldentity, Role newEntity)
        {
            oldentity.Id = newEntity.Id;
            oldentity.Description = newEntity.Description;
            return oldentity;
        }
    }
}

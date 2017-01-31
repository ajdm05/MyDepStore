using MyDepStore.Database.Model;
using System.Linq;

namespace MyDepStore.Database.Repository
{
    public class PrivilegeRepository : BaseRepository<Privilege>
    {
        public PrivilegeRepository(MyDepStoreContext context) : base(context)
        { }

        public override IQueryable<Privilege> All()
        {
            return this.Context.Privileges;
        }

        protected override Privilege MapNewValuesToOld(Privilege oldentity, Privilege newEntity)
        {
            oldentity.Id = newEntity.Id;
            oldentity.Description = newEntity.Description;
            return oldentity;
        }
    }
}

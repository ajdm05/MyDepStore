using MyDepStore.Database.Model;
using System.Linq;

namespace MyDepStore.Database.Repository
{
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(MyDepStoreContext context) : base (context)
        {
        }

        public override IQueryable<Client> All()
        {
            return this.Context.Clients;
        }

        protected override Client MapNewValuesToOld(Client oldentity, Client newEntity)
        {
            oldentity.Id = newEntity.Id;
            oldentity.FirstName = newEntity.FirstName;
            oldentity.LastName = newEntity.LastName;
            oldentity.IdNumber = newEntity.IdNumber;
            oldentity.IsActive = newEntity.IsActive;
            return oldentity;
        }
    }
}

using MyDepStore.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDepStore.Database.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(MyDepStoreContext context) : base(context)
        {
        }

        public override IQueryable<User> All()
        {
            return this.Context.Users;
        }

        protected override User MapNewValuesToOld(User oldEntity, User newEntity)
        {
            oldEntity.Username = newEntity.Username;
            oldEntity.FirstName = newEntity.FirstName;
            oldEntity.LastName = newEntity.LastName;
            oldEntity.Email = newEntity.Email;
            oldEntity.Password = newEntity.Password;
            oldEntity.IsActive = newEntity.IsActive;
            return oldEntity;
        }
    }
}

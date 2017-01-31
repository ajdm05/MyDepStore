using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("ROLES")]
    public class Role
    {
        [Key]
        [Column("ID")]
        [StringLength(50)]
        public string Id { get; set; }

        [Column("DESCRIPTION")]
        [StringLength(200)]
        public string Description { get; set; }

        public virtual ICollection<Privilege> Privileges { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

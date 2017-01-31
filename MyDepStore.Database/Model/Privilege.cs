using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("PRIVILEGES")]
    public class Privilege
    {
        [Key]
        [Column("ID")]
        [StringLength(100)]
        public string Id { get; set; }

        [Column("DESCRIPTION")]
        [StringLength(200)]
        public string Description { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("CLIENTS", Schema = "public")]
    public class Client
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("FIRST_NAME")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column("LAST_NAME")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("ID_NUMBER")]
        [StringLength(20)]
        public string IdNumber { get; set; }

        [Column("ACTIVE")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}

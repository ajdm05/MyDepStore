using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("USERS", Schema = "public")]
    public class User
    {
        [Key]
        [Column("USERNAME")]
        [StringLength(50)]
        public string Username { get; set; }

        [ForeignKey("Role")]
        [Column("ROLE")]
        [StringLength(20)]
        public string RoleId { get; set; }

        [Column("FIRST_NAME")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column("LAST_NAME")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column("EMAIL")]
        [StringLength(200)]
        public string Email { get; set; }

        [Column("PASSWORD")]
        [StringLength(40)]
        public string Password { get; set; }

        [Column("ACTIVE")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        public virtual Role Role { get; set; }
    }
}

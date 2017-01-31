using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("BRANCH_OFFICE")]
    public class BranchOffice
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(200)]
        public string Name { get; set; }

        [Column("ACTIVE")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}

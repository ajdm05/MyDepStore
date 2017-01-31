using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("INVOICE_HEADER")]
    public class HeaderInvoice
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}

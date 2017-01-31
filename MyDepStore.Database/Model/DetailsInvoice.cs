using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDepStore.Database.Model
{
    [Table("INVOICE_DETAILS")]
    public class DetailsInvoice
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}

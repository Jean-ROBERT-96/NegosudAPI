using NegosudAPI.Models.EntityFolder;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.OrderFolder
{
    [Table("PurchaseOrder")]
    public class PurchaseOrder
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public string Date { get; set; }
        [Column("id_vendor")]
        public int IdVendor { get; set; }
        [ForeignKey("IdVendor")]
        public Vendor Vendor { get; set; }
    }
}

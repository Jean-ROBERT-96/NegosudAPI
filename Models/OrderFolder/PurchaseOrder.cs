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
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("id_vendor")]
        public int IdVendor { get; set; }
        [Column("id_article")]
        public int IdArticle { get; set; }
    }
}

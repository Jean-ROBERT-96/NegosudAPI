using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.OrderFolder;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.RelationFolder
{
    [Keyless]
    [Table("Content")]
    public class Content
    {
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("id_article")]
        public int IdArticle { get; set; }
        [Column("id_purchase_order")]
        public int IdPurchaseOrder { get; set; }
        [ForeignKey("IdArticle")]
        public ICollection<Article> Article { get; set; }
        [ForeignKey("IdPurchaseOrder")]
        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}

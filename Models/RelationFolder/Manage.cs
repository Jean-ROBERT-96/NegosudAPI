using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.RelationFolder
{
    [Table("Manage")]
    public class Manage
    {
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("id_user")]
        public int IdUser { get; set; }
        [Column("id_article")]
        public int IdArticle { get; set; }
        [ForeignKey("IdUser")]
        public ICollection<User> User { get; set; }
        [ForeignKey("IdArticle")]
        public ICollection<Article> Article { get; set; }
    }
}

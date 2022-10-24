using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.ArticleFolder
{
    [Table("Article")]
    public class Article
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("year")]
        public string Year { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("price")]
        public float Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("id_family")]
        public int IdFamily { get; set; }
    }
}

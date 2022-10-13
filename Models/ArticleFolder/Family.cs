using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.ArticleFolder
{
    [Table("Family")]
    public class Family
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("description")]
        public string Description { get; set; }
    }
}

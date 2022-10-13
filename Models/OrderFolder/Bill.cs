using NegosudAPI.Models.EntityFolder;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.OrderFolder
{
    [Table("Bill")]
    public class Bill
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("sum")]
        public float Sum { get; set; }
        [Column("date")]
        public string Date { get; set; }
        [Column("id_client")]
        public int IdClient { get; set; }
        [ForeignKey("IdClient")]
        public Client Client { get; set; }
    }
}

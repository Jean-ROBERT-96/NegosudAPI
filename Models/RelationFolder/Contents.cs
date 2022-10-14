using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.EntityFolder;
using NegosudAPI.Models.OrderFolder;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.RelationFolder
{
    [Keyless]
    [Table("Contents")]
    public class Contents
    {
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("id_bill")]
        public int IdBill { get; set; }
        [Column("id_client")]
        public int IdClient { get; set; }
        [ForeignKey("IdBill")]
        public ICollection<Bill> Bill { get; set; }
        [ForeignKey("IdClient")]
        public ICollection<Client> Client { get; set; }
    }
}

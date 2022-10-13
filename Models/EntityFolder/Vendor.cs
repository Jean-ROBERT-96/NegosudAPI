using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.EntityFolder
{
    [Table("Vendor")]
    public class Vendor
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("compagny_name")]
        public string CompagnyName { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("mail")]
        public string Mail { get; set; }
        [Column("adress")]
        public string Adress { get; set; }
        [Column("complement")]
        public string? Complement { get; set; }
        [Column("zip_code")]
        public int ZipCode { get; set; }
        [Column("city")]
        public string City { get; set; }
    }
}

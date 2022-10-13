using System.ComponentModel.DataAnnotations.Schema;

namespace NegosudAPI.Models.EntityFolder
{
    [Table("Client")]
    public class Client
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FistName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
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

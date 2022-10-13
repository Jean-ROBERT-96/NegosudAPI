using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace NegosudAPI.Models.EntityFolder
{
    [Table("User")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("mail")]
        public string Mail { get; set; }
        [Column("password")]
        public string Password { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;
using NegosudAPI.Models.OrderFolder;
using NegosudAPI.Models.RelationFolder;

namespace NegosudAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Article
        public DbSet<Article> articles { get; set; }
        public DbSet<Family> families { get; set; }
        //Entity
        public DbSet<Client> clients { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Vendor> vendor { get; set; }
        //Order
        public DbSet<Bill> bills { get; set; }
        public DbSet<PurchaseOrder> purchaseOrders { get; set; }
        //Relation
        public DbSet<Content> contents { get; set; }
        public DbSet<Contents> contents2 { get; set; }
        public DbSet<Manage> manages { get; set; }
    }
}

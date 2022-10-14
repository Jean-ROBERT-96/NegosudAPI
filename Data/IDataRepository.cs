using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;
using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Data
{
    public interface IUserRepository
    {
        Task<User?> GetUser(string mail);
    }

    public interface IClientRepository
    {
        Task<List<Client>> GetAllClient();
        Task<List<Client?>> GetClient(string name);
        Task<Client?> GetClientById(int id);
        Task<Client> PostClient(Client client);
        Task<Client?> PutClient(int id, Client client);
        Task<Client?> DeleteClient(int id);
    }

    public interface IVendorRepository
    {
        Task<List<Vendor>> GetAllVendor();
        Task<List<Vendor?>> GetVendor(string name);
        Task<Vendor?> GetVendorById(int id);
        Task<Vendor> PostVendor(Vendor vendor);
        Task<Vendor?> PutVendor(int id, Vendor vendor);
        Task<Vendor?> DeleteVendor(int id);
    }

    public interface IArticleRepository
    {
        Task<List<Article>> GetAllArticles();
        Task<List<Article?>> GetArticle(string name);
        Task<Article?> GetArticleById(int id);
        Task<Article> PostArticle(Article article);
        Task<Article?> PutArticle(int id, Article article);
        Task<Article?> DeleteArticle(int id);
    }

    public interface IFamilyRepository
    {
        Task<List<Family>> GetAllFamilies();
        Task<List<Family?>> GetFamily(string name);
        Task<Family?> GetFamilyById(int id);
        Task<Family> PostFamily(Family family);
        Task<Family?> PutFamily(int id, Family family);
        Task<Family?> DeleteFamily(int id);
    }

    public interface IPurchaseOrderRepository
    {
        Task<List<PurchaseOrder>> GetAllPurchaseOrder();
        Task<PurchaseOrder?> GetPurchaseOrderById(int id);
        Task<PurchaseOrder> PostPurchaseOrder(PurchaseOrder purchaseOrder);
    }
}

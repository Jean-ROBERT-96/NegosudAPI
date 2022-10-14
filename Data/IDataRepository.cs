using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;
using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Data
{
    public interface IUserRepository
    {
        User GetUser(string mail);
    }

    public interface IClientRepository
    {
        List<Client> GetAllClient();
        List<Client> GetClient(string name);
        Client GetClientById(int id);
    }

    public interface IVendorRepository
    {
        List<Vendor> GetAllVendor();
        List<Vendor> GetVendor(string name);
        Vendor GetVendorById(int id);
    }

    public interface IArticleRepository
    {
        List<Article> GetAllArticles();
        List<Article> GetArticle(string name);
        Article GetArticleById(int id);
    }

    public interface IFamilyRepository
    {
        List<Family> GetAllFamilies();
        List<Family> GetFamily(string type);
        Family GetFamilyById(int id);
    }

    public interface IPurchaseOrderRepository
    {
        List<PurchaseOrder> GetAllPurchaseOrder();
        PurchaseOrder GetPurchaseOrderById(int id);
    }
}

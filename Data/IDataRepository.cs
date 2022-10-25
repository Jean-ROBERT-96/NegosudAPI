using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;
using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Data
{
    public interface IUserRepository
    {
        Task<User?> GetUser(string mail);
    }

    public interface IDataRepository<T>
    {
        Task<List<T>> Get();
        Task<List<T>> Get(string name);
        Task<T?> Get(int id);
        Task<T> Post(T objects);
        Task<T?> Put(int id, T objects);
        Task<T?> Delete(int id);
    }

    public interface IPurchaseOrderRepository
    {
        Task<List<PurchaseOrder>> GetAllPurchaseOrder();
        Task<PurchaseOrder?> GetPurchaseOrderById(int id);
        Task<PurchaseOrder> PostPurchaseOrder(PurchaseOrder purchaseOrder);
    }
}

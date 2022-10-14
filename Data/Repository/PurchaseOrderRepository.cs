using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Data.Repository
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        DataContext _context;

        public PurchaseOrderRepository(DataContext context)
        {
            _context = context;
        }

        public List<PurchaseOrder> GetAllPurchaseOrder()
        {
            return _context.purchaseOrders.ToList();
        }

        public PurchaseOrder GetPurchaseOrderById(int id)
        {
            return _context.purchaseOrders.FirstOrDefault(i => i.Id == id);
        }
    }
}

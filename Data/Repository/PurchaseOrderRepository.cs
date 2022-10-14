using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;
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

        public async Task<List<PurchaseOrder>> GetAllPurchaseOrder()
        {
            return await _context.purchaseOrders.ToListAsync();
        }

        public async Task<PurchaseOrder?> GetPurchaseOrderById(int id)
        {
            return await _context.purchaseOrders.FindAsync(id);
        }

        public async Task<PurchaseOrder> PostPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _context.purchaseOrders.Add(purchaseOrder);
            await _context.SaveChangesAsync();
            return purchaseOrder;
        }
    }
}

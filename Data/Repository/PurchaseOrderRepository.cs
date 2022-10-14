namespace NegosudAPI.Data.Repository
{
    public class PurchaseOrderRepository : IDataRepository
    {
        DataContext _context;

        public PurchaseOrderRepository(DataContext context)
        {
            _context = context;
        }
    }
}

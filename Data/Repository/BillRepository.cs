using NegosudAPI.Models.OrderFolder;

namespace NegosudAPI.Data.Repository
{
    public class BillRepository
    {
        DataContext _context;
        
        public BillRepository(DataContext context)
        {
            _context = context;
        }

        public List<Bill> GetAllBills()
        {
            return _context.bills.ToList();
        }

        public Bill GetBillById(int id)
        {
            return _context.bills.FirstOrDefault(i => i.Id == id);
        }
    }
}

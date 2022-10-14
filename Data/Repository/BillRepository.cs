namespace NegosudAPI.Data.Repository
{
    public class BillRepository : IDataRepository
    {
        DataContext _context;
        
        public BillRepository(DataContext context)
        {
            _context = context;
        }
    }
}

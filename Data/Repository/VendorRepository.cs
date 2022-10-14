namespace NegosudAPI.Data.Repository
{
    public class VendorRepository : IDataRepository
    {
        DataContext _context;

        public VendorRepository(DataContext context)
        {
            _context = context;
        }
    }
}

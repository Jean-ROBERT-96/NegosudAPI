using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Data.Repository
{
    public class VendorRepository : IVendorRepository
    {
        DataContext _context;

        public VendorRepository(DataContext context)
        {
            _context = context;
        }

        public List<Vendor> GetAllVendor()
        {
            return _context.vendor.ToList();
        }

        public List<Vendor> GetVendor(string name)
        {
            return _context.vendor.Where(a => a.CompagnyName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Vendor GetVendorById(int id)
        {
            return _context.vendor.FirstOrDefault(i => i.Id == id);
        }
    }
}

using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Vendor>> GetAllVendor()
        {
            return await _context.vendor.ToListAsync();
        }

        public async Task<List<Vendor?>> GetVendor(string name)
        {
            return await _context.vendor.Where(a => a.CompagnyName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Vendor?> GetVendorById(int id)
        {
            return await _context.vendor.FindAsync(id);
        }

        public async Task<Vendor> PostVendor(Vendor vendor)
        {
            _context.vendor.Add(vendor);
            await _context.SaveChangesAsync();
            return vendor;
        }

        public async Task<Vendor?> PutVendor(int id, Vendor vendor)
        {
            if (vendor.Id != null)
                return null;

            if (await _context.vendor.FindAsync(id) == null)
                return null;

            _context.Entry(vendor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return vendor;
        }

        public async Task<Vendor?> DeleteVendor(int id)
        {
            var result = await _context.vendor.FindAsync(id);
            if (result == null)
                return null;

            _context.vendor.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

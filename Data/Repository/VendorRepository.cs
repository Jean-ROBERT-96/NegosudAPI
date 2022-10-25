using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Data.Repository
{
    public class VendorRepository : IDataRepository<Vendor>
    {
        private readonly DataContext _context;

        public VendorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Vendor>> Get()
        {
            return await _context.vendor.ToListAsync();
        }

        public async Task<List<Vendor>> Get(string name)
        {
            return await _context.vendor.Where(a => a.CompagnyName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Vendor?> Get(int id)
        {
            return await _context.vendor.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Vendor> Post(Vendor vendor)
        {
            _context.vendor.Add(vendor);
            await _context.SaveChangesAsync();
            return vendor;
        }

        public async Task<Vendor?> Put(int id, Vendor vendor)
        {
            var result = await _context.vendor.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if(result == null)
                return null;

            _context.Entry(vendor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return vendor;
        }

        public async Task<Vendor?> Delete(int id)
        {
            var result = await _context.vendor.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if (result == null)
                return null;

            _context.vendor.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

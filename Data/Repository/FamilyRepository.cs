using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Data.Repository
{
    public class FamilyRepository : IDataRepository<Family>
    {
        private readonly DataContext _context;

        public FamilyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Family>> Get()
        {
            return await _context.families.ToListAsync();
        }

        public async Task<List<Family>> Get(string name)
        {
            return await _context.families.Where(a => a.Type.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Family?> Get(int id)
        {
            return await _context.families.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Family> Post(Family family)
        {
            _context.families.Add(family);
            await _context.SaveChangesAsync();
            return family;
        }

        public async Task<Family?> Put(int id, Family family)
        {
            var result = await _context.families.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if(result == null)
                return null;

            _context.Entry(family).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return family;
        }

        public async Task<Family?> Delete(int id)
        {
            var result = await _context.families.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if (result == null)
                return null;

            _context.families.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

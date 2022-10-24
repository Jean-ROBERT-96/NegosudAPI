using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Data.Repository
{
    public class FamilyRepository : IFamilyRepository
    {
        DataContext _context;

        public FamilyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Family>> GetAllFamilies()
        {
            return await _context.families.ToListAsync();
        }

        public async Task<List<Family?>> GetFamily(string name)
        {
            return await _context.families.Where(a => a.Type.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Family?> GetFamilyById(int id)
        {
            return await _context.families.FindAsync(id);
        }

        public async Task<Family> PostFamily(Family family)
        {
            _context.families.Add(family);
            await _context.SaveChangesAsync();
            return family;
        }

        public async Task<Family?> PutFamily(int id, Family family)
        {
            //TODO : Vérifier si l'item existe.
            /*if (family.Id != null)
                return null;

            if (await _context.families.FindAsync(id) == null)
                return null;*/

            _context.Entry(family).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return family;
        }

        public async Task<Family?> DeleteFamily(int id)
        {
            var result = await _context.families.FindAsync(id);
            if (result == null)
                return null;

            _context.families.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

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

        public List<Family> GetAllFamilies()
        {
            return _context.families.ToList();
        }

        public List<Family> GetFamily(string type)
        {
            return _context.families.Where(a => a.Type.Contains(type, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Family GetFamilyById(int id)
        {
            return _context.families.FirstOrDefault(i => i.Id == id);
        }
    }
}

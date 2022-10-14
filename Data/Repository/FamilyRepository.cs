namespace NegosudAPI.Data.Repository
{
    public class FamilyRepository : IDataRepository
    {
        DataContext _context;

        public FamilyRepository(DataContext context)
        {
            _context = context;
        }
    }
}

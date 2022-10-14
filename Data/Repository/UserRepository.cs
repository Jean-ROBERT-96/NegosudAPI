namespace NegosudAPI.Data.Repository
{
    public class UserRepository : IDataRepository
    {
        DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
    }
}

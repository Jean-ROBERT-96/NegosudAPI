namespace NegosudAPI.Data.Repository
{
    public class ClientRepository : IDataRepository
    {
        DataContext _context;
        
        public ClientRepository(DataContext context)
        {
            _context = context;
        }
    }
}

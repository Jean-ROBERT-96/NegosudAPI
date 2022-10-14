using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        DataContext _context;
        
        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public List<Client> GetAllClient()
        {
            return _context.clients.ToList();
        }

        public List<Client> GetClient(string name)
        {
            return _context.clients.Where(a => a.FistName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.clients.FirstOrDefault(i => i.Id == id);
        }
    }
}

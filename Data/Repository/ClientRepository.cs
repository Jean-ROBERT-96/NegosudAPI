using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Client>> GetAllClient()
        {
            return await _context.clients.ToListAsync();
        }

        public async Task<List<Client?>> GetClient(string name)
        {
            return await _context.clients.Where(a => a.FistName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Client?> GetClientById(int id)
        {
            return await _context.clients.FindAsync(id);
        }

        public async Task<Client> PostClient(Client client)
        {
            _context.clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client?> PutClient(int id, Client client)
        {
            if (client.Id != null)
                return null;

            if (await _context.clients.FindAsync(id) == null)
                return null;

            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return client;
        }

        public async Task<Client?> DeleteClient(int id)
        {
            var result = await _context.clients.FindAsync(id);
            if (result == null)
                return null;

            _context.clients.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

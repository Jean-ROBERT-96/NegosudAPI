using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Data.Repository
{
    public class ClientRepository : IDataRepository<Client>
    {
        private readonly DataContext _context;
        
        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> Get()
        {
            return await _context.clients.ToListAsync();
        }

        public async Task<List<Client>> Get(string name)
        {
            return await _context.clients.Where(a => a.FistName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Client?> Get(int id)
        {
            return await _context.clients.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Client> Post(Client client)
        {
            _context.clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client?> Put(int id, Client client)
        {
            var result = await _context.clients.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if(result == null)
                return null;

            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return client;
        }

        public async Task<Client?> Delete(int id)
        {
            var result = await _context.clients.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if (result == null)
                return null;

            _context.clients.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

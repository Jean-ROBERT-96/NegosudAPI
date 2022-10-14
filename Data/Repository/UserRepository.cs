using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;
using NegosudAPI.Models.EntityFolder;

namespace NegosudAPI.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUser(string mail)
        {
            return await _context.users.FirstOrDefaultAsync(a => a.Mail == mail);
        }
    }
}

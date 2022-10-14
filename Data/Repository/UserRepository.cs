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

        public User GetUser(string mail)
        {
            return _context.users.FirstOrDefault(a => a.Mail == mail);
        }
    }
}

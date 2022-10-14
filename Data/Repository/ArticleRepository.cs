namespace NegosudAPI.Data.Repository
{
    public class ArticleRepository : IDataRepository
    {
        DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }
    }
}

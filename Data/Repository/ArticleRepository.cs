using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Data.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public List<Article> GetAllArticles()
        {
            return _context.articles.ToList();
        }

        public List<Article> GetArticle(string name)
        {
            return _context.articles.Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.articles.FirstOrDefault(i => i.Id == id);
        }
    }
}

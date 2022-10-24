using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Article>> GetAllArticles()
        {
            return await _context.articles.ToListAsync();
        }

        public async Task<List<Article?>> GetArticle(string name)
        {
            return await _context.articles.Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Article?> GetArticleById(int id)
        {
            return await _context.articles.FindAsync(id);
        }

        public async Task<Article> PostArticle(Article article)
        {
            _context.articles.Add(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<Article?> PutArticle(int id, Article article)
        {
            //TODO : Vérifier si l'item existe.
            /*if (article.Id != null)
                return null;
            var result = await _context.articles.FindAsync(id);
            if (result == null)
                return null;*/

            _context.Entry(article).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return article;
        }

        public async Task<Article?> DeleteArticle(int id)
        {
            var result = await _context.articles.FindAsync(id);
            if (result == null)
                return null;

            _context.articles.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

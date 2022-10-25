using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models.ArticleFolder;

namespace NegosudAPI.Data.Repository
{
    public class ArticleRepository : IDataRepository<Article>
    {
        private readonly DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Article>> Get()
        {
            return await _context.articles.ToListAsync();
        }

        public async Task<List<Article>> Get(string name)
        {
            return await _context.articles.Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public async Task<Article?> Get(int id)
        {
            return await _context.articles.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Article> Post(Article article)
        {
            _context.articles.Add(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<Article?> Put(int id, Article article)
        {
            var result = await _context.articles.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if(result == null)
                return null;

            _context.Attach(article).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return article;
        }

        public async Task<Article?> Delete(int id)
        {
            var result = await _context.articles.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if (result == null)
                return null;

            _context.articles.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }
    }
}

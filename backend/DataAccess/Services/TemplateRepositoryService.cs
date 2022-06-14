using Data;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class TemplateRepositoryService : ITemplateRepositoryService
    {
        //private readonly Dictionary<int, string> _items;
        //private int _id;
        private readonly TemplateDbContext _dbContext;

        public TemplateRepositoryService(TemplateDbContext dbContext)
        {
            _dbContext = dbContext;
            //This is to ensure that the Db is created. Should only be needed for In Memory. 
            _dbContext.Database.EnsureCreated();
        }

        public bool Create(string newThing)
        {
            if (_dbContext.Templates.Any(t => t.Value == newThing))
                return false;
            
            _dbContext.Templates.Add(new TemplateData{ Value = newThing });
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<bool> CreateAsync(string newThing)
        {
            if (await _dbContext.Templates.AnyAsync(t => t.Value == newThing))
                return false;

            await _dbContext.Templates.AddAsync(new TemplateData{ Value = newThing });
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public bool DeleteOne(int id)
        {
            var target = _dbContext.Templates.FirstOrDefault(t => t.Id == id);
            
            if (target is null)
                return false;

            _dbContext.Templates.Remove(target);
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteOneAsync(int id)
        {
            var target = await _dbContext.Templates.FirstOrDefaultAsync(t => t.Id == id);
            
            if (target is null)
                return false;

            _dbContext.Templates.Remove(target);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public ICollection<string> ReadAll()
        {
            return _dbContext.Templates.Select(t => t.Value).ToList();
        }

        public async Task<ICollection<string>> ReadAllAsync()
        {
            return await _dbContext.Templates.Select(t => t.Value).ToListAsync();
        }

        public string ReadOne(int id)
        {
            var target = _dbContext.Templates.FirstOrDefault(t => t.Id == id);
            return target is not null ? target.Value : string.Empty;
        }

        public async Task<string> ReadOneAsync(int id)
        {
            var target = await _dbContext.Templates.FirstOrDefaultAsync(t => t.Id == id);
            return target is not null ? target.Value : string.Empty;
        }

        public bool UpdateOne(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateOneAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
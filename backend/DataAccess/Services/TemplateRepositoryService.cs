using DataAccess.Services.Interfaces;

namespace DataAccess.Services
{
    public class TemplateRepositoryService : ITemplateRepositoryService
    {

        private readonly Dictionary<int, string> _items;
        int id;

        public TemplateRepositoryService()
        {
            _items = new Dictionary<int, string> { { 1, "Banana" }, { 2, "Apple" }, { 3, "Orange" }, { 4, "Cherry" } };
            id = _items.Count();
        }

        public bool Create(string newThing)
        {
            if (_items.Values.Any(i => i.Equals(newThing)))
            {
                return false;
            }

            _items.Add(id, newThing);
            id++;
            return true;
        }

        public async Task<bool> CreateAsync(string newThing)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteOneAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<string> ReadAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<string>> ReadAllAsync()
        {
            return _items.Values.ToList();
        }

        public string ReadOne(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> ReadOneAsync(int id)
        {
            throw new NotImplementedException();
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
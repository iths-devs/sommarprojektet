namespace DataAccess.Services.Interfaces
{
    public interface ITemplateRepositoryService
    {
        //CRUD-methods
        bool Create(string newThing);
        ICollection<string> ReadAll();
        string ReadOne(int id);
        bool UpdateOne(int id, string value);
        bool DeleteOne(int id);

        //Async CRUD-methods
        Task<bool> CreateAsync(string newThing);
        Task<ICollection<string>> ReadAllAsync();
        Task<string> ReadOneAsync(int id);
        Task<bool> UpdateOneAsync(int id, string value);
        Task<bool> DeleteOneAsync(int id);
    }
}
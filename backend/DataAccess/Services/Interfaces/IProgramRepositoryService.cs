using Data;

namespace DataAccess.Services.Interfaces;

public interface IProgramRepositoryService
{
    //CRUD-methods
    bool Create(Program program);
    ICollection<Program> ReadAll();
    Program? ReadOne(int id);
    bool UpdateOne(int id, Program program);
    bool DeleteOne(int id);

    //Async CRUD-methods
    Task<bool> CreateAsync(Program program);
    Task<ICollection<Program>> ReadAllAsync();
    Task<Program?> ReadOneAsync(int id);
    Task<bool> UpdateOneAsync(int id, Program program);
    Task<bool> DeleteOneAsync(int id);
}
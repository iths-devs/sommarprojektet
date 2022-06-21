using Data;

namespace DataAccess.Services.Interfaces;

public interface ICourseRepositoryService
{
    //CRUD-methods
    bool Create(Course course);
    ICollection<Course> ReadAll();
    Course? ReadOne(int id);
    bool UpdateOne(int id, Course course);
    bool DeleteOne(int id);

    //Async CRUD-methods
    Task<bool> CreateAsync(Course course);
    Task<ICollection<Course>> ReadAllAsync();
    Task<Course?> ReadOneAsync(int id);
    Task<bool> UpdateOneAsync(int id, Course course);
    Task<bool> DeleteOneAsync(int id);
}
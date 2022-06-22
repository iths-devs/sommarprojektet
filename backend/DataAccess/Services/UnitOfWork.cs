using Data;

namespace DataAccess.Services;

public class UnitOfWork
{
    private readonly SchoolDbContext _dbContext;
    private readonly CourseRepositoryService _courseRepository;

    public UnitOfWork(SchoolDbContext dbContext, CourseRepositoryService courseRepository)
    {
        _dbContext = dbContext;
        _courseRepository = courseRepository;
    }
    
    public bool AddCourse(Course course)
    {
        if (!_courseRepository.Create(course))
            return false;
        _dbContext.SaveChanges();
        return true;
    }

    public ICollection<Course> GetAllCourses()
    {
        return _courseRepository.ReadAll();
    }

    public Course? GetCourse(int id)
    {
        return _courseRepository.ReadOne(id);
    }

    public bool UpdateCourse(int id, Course course)
    {
        if (!_courseRepository.UpdateOne(id, course))
            return false;
        _dbContext.SaveChanges();
        return true;
    }

    public bool DeleteCourse(int id)
    {
        if (!_courseRepository.DeleteOne(id))
            return false;
        _dbContext.SaveChanges();
        return true;
    }
}
using Data;
using DataAccess.Services.Interfaces;

namespace DataAccess.Services;

public class UnitOfWork
{
    private readonly SchoolDbContext _dbContext;
    private readonly IProgramRepositoryService _programRepository;
    private readonly ICourseRepositoryService _courseRepository;

    public UnitOfWork(SchoolDbContext dbContext, ICourseRepositoryService courseRepository, IProgramRepositoryService programRepository)
    {
        _dbContext = dbContext;
        _courseRepository = courseRepository;
        _programRepository = programRepository;
    }

    #region ProgramMethods

    public bool AddProgram(Program program)
    {
        if (!_programRepository.Create(program))
            return false;
        _dbContext.SaveChanges();
        return true;
    }


    #endregion
    #region CourseMethods
    public bool AddCourse(Course course)
    {
        if (!_courseRepository.Create(course))
            return false;
        _dbContext.SaveChanges();
        return true;
    }

    public ICollection<Course> GetCourses()
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
    #endregion
}
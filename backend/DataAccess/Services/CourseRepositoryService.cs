using Data;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class CourseRepositoryService : ICourseRepositoryService
{
    private readonly SchoolDbContext _dbContext;

    public CourseRepositoryService(SchoolDbContext dbContext)
    {
        _dbContext = dbContext;
        
        //This is to ensure that the Db is created. Should only be needed for In Memory. 
        _dbContext.Database.EnsureCreated();
    }

    public bool Create(Course course)
    {
        if (_dbContext.Courses.Any(c => c.Title == course.Title))
            return false;
        _dbContext.Courses.Add(course);
        return true;
    }

    public ICollection<Course> ReadAll()
    {
        return _dbContext.Courses.ToList();
    }

    public Course? ReadOne(int id)
    {
        return _dbContext.Courses.FirstOrDefault(c => c.Id == id);
    }

    public bool UpdateOne(int id, Course course)
    {
        var target = _dbContext.Courses.FirstOrDefault(c => c.Id == id);
        if (target is null)
            return false;
        target.Title = course.Title;
        target.Description = course.Description;
        target.StartDate = course.StartDate;
        target.EndDate = course.EndDate;
        target.GradeScale = course.GradeScale;
        target.Manager = course.Manager;
        target.Teachers = course.Teachers;
        target.Enrollments = course.Enrollments;
        target.Posts = course.Posts;
        target.Assignments = course.Assignments;
        return true;
    }

    public bool DeleteOne(int id)
    {
        var target = _dbContext.Courses.FirstOrDefault(c => c.Id == id);
        if (target is null)
            return false;
        _dbContext.Courses.Remove(target);
        return true;
    }

    public async Task<bool> CreateAsync(Course course)
    {
        if (_dbContext.Courses.Any(c => c.Id == course.Id))
            return false;
        await _dbContext.Courses.AddAsync(course);
        return true;
    }

    public async Task<ICollection<Course>> ReadAllAsync()
    {
        return await _dbContext.Courses.ToListAsync();
    }

    public async Task<Course?> ReadOneAsync(int id)
    {
        return await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<bool> UpdateOneAsync(int id, Course course)
    {
        var target = await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == id);
        if (target is null)
            return false;
        target.Title = course.Title;
        target.Description = course.Description;
        target.StartDate = course.StartDate;
        target.EndDate = course.EndDate;
        target.GradeScale = course.GradeScale;
        target.Manager = course.Manager;
        target.Teachers = course.Teachers;
        target.Enrollments = course.Enrollments;
        target.Posts = course.Posts;
        target.Assignments = course.Assignments;
        return true;
    }

    public async Task<bool> DeleteOneAsync(int id)
    {
        var target = await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == id);
        if (target is null)
            return false;
        _dbContext.Courses.Remove(target);
        return true;
    }
    
    // TODO:
    // Ska Enrollment <-> Course vara two way relation?
    // Borde Enrollments Id vara en Composite Key av Student + Course?
}
        
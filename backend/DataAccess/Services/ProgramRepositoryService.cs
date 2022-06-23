using Data;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class ProgramRepositoryService : IProgramRepositoryService
{
    private readonly SchoolDbContext _dbContext;

    public ProgramRepositoryService(SchoolDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public bool Create(Program program)
    {
        if (_dbContext.Programs.Any(p => p.Title == program.Title))
            return false;
        _dbContext.Programs.Add(program);
        return true;
    }

    public ICollection<Program> ReadAll()
    {
        return _dbContext.Programs.ToList();
    }

    public Program? ReadOne(int id)
    {
        return _dbContext.Programs.FirstOrDefault(p => p.Id == id);
    }

    public bool UpdateOne(int id, Program program)
    {
        var target = _dbContext.Programs.FirstOrDefault(p => p.Id == id);
        if (target is null)
            return false;
        target.Title = program.Title;
        target.Description = program.Description;
        target.Location = program.Location;
        target.Manager = program.Manager;
        target.Students = program.Students;
        target.Courses = program.Courses;
        target.Posts = program.Posts;
        return true;
    }

    public bool DeleteOne(int id)
    {
        var target = _dbContext.Programs.FirstOrDefault(p => p.Id == id);
        if (target is null)
            return false;
        _dbContext.Programs.Remove(target);
        return true;
    }

    public async Task<bool> CreateAsync(Program program)
    {
        if (await _dbContext.Programs.AnyAsync(p => p.Title == program.Title))
            return false;
        await _dbContext.Programs.AddAsync(program);
        return true;
    }

    public async Task<ICollection<Program>> ReadAllAsync()
    {
        return await _dbContext.Programs.ToListAsync();
    }

    public async Task<Program?> ReadOneAsync(int id)
    {
        return await _dbContext.Programs.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<bool> UpdateOneAsync(int id, Program program)
    {
        var target = await _dbContext.Programs.FirstOrDefaultAsync(p => p.Id == id);
        if (target is null)
            return false;
        target.Title = program.Title;
        target.Description = program.Description;
        target.Location = program.Location;
        target.Manager = program.Manager;
        target.Students = program.Students;
        target.Courses = program.Courses;
        target.Posts = program.Posts;
        return true;
    }

    public async Task<bool> DeleteOneAsync(int id)
    {
        var target = await _dbContext.Programs.FirstOrDefaultAsync(p => p.Id == id);
        if (target is null)
            return false;
        _dbContext.Programs.Remove(target);
        return true;
    }
}
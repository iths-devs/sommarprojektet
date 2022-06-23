using Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class SchoolDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Program> Programs => Set<Program>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Assignment> Assignments => Set<Assignment>();
    public DbSet<StudentAssignment> StudentAssignments => Set<StudentAssignment>();
    public DbSet<Attachment> Attachments => Set<Attachment>();

    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
    { }
    
    // This is for seeding the InMemoryDatabase
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Program>().HasData(new Program
        {
            Id = 1,
            Title = "Ett testprogram för databasmodellering",
            Description = "Det här är ett testprogram för dig som älskar att testa om databasmodellerna fungerar som de ska.",
            Location = "IT-Högskolan Göteborg"
        });
        modelBuilder.Entity<Course>().HasData(new Course
        {
            Id = 1,
            Title = "Pulse width modulation and mosfet",
            Description = "This course will not make you a better gardener...",
            StartDate = new DateTime(2022, 08, 22),
            EndDate = new DateTime(2022, 12, 5),
            GradeScale = GradeScale.IgVg,
        });
    }
}
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
            Location = "IT-Högskolan Göteborg",
        });
        // var mUserS = new User
        // {
        //     Id = Guid.NewGuid(),
        //     Roles = new List<Role>(){new (){Id = 1, Name = "Student"}}
        // };
        // var mUserT = new User
        // {
        //     Id = Guid.NewGuid(),
        //     Roles = new List<Role>(){new (){Id = 2, Name = "Teacher"}}
        // };
        // var mUserPm = new User
        // {
        //     Id = Guid.NewGuid(),
        //     Roles = new List<Role>(){new (){Id = 3, Name = "ProgramManager"}}
        // };
        // var mProgram = new Program
        // {
        //     Id = 1,
        //     Title = "Ett testprogram för databasmodellering",
        //     Description = "Det här är ett testprogram för dig som älskar att testa om databasmodellerna fungerar som de ska.",
        //     Location = "IT-Högskolan Göteborg",
        //     Manager = mUserPm,
        // };
        // var mCourse = new Course
        // {
        //     Id = 1,
        //     Title = "Database modelling 101",
        //     Description = "Det här är en testkurs för att testa databasmodellerna.",
        //     StartDate = new DateOnly(2022,08,16),
        //     EndDate = new DateOnly(2022, 12, 2),
        //     GradeScale = GradeScale.IgVg,
        //     Manager = mUserPm
        // };
        // var mEnrollment = new Enrollment
        // {
        //     Id = 1,                             // Borde det här vara en CompositeKey? 
        //     Student = mUserS,
        //     Course = mCourse,                   // Ska det här vara two-way relationship?
        // };
        // var mPostC = new Post
        // {
        //     Id = 1,
        //     Title = "Testpost Course.",
        //     Content = "Det här är en testpost för en kurs att testa databasmodellerna."
        // };
        // var mPostP = new Post
        // {
        //     Id = 2,
        //     Title = "Testpost Program.",
        //     Content = "Det här är en testpost för ett program för att testa databasmodellerna."
        // };
        // var mAssignment = new Assignment
        // {
        //     Id = 1,
        //     Course = mCourse,
        //     AssignmentType = AssignmentType.Assignment,
        //     Title = "Test assignment",
        //     Content = "Det här är en testuppgift för att testa databasmodellerna.",
        //     Graded = true,
        // };
        // var mStudentAssignment = new StudentAssignment
        // {
        //     Id = 1,
        //     Assignment = mAssignment,
        //     Enrollment = mEnrollment,
        // };
        // var mAttachment = new Attachment
        // {
        //     Id = 1,
        //     StudentAssignment = mStudentAssignment,
        //     Content = "Det här är en testbilaga för att testa databasmodellerna."
        // };
        //
        // mAssignment.StudentAssignments.Add(mStudentAssignment);
        // mEnrollment.Assignments.Add(mAssignment);
        // mCourse.Teachers.Add(mUserT);
        // mCourse.Enrollments.Add(mEnrollment);
        // mCourse.Posts.Add(mPostC);
        // mCourse.Assignments.Add(mAssignment);
        // mProgram.Courses.Add(mCourse);
        // mProgram.Posts.Add(mPostP);
        //
        // modelBuilder.Entity<Program>().HasData(mProgram);
        // modelBuilder.Entity<Course>().HasData(mCourse);
        // modelBuilder.Entity<Enrollment>().HasData(mEnrollment);
        // modelBuilder.Entity<Post>().HasData(mPostC, mPostP);
        // modelBuilder.Entity<Assignment>().HasData(mAssignment);
        // modelBuilder.Entity<StudentAssignment>().HasData(mStudentAssignment);
        // modelBuilder.Entity<Attachment>().HasData(mAttachment);
    }
}
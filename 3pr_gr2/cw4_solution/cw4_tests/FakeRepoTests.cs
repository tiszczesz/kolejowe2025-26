namespace cw4_tests;
using cw4_class.Models;

using Xunit;

public class FakeRepoTests
{
    [Fact]
    public void Is_fakeRepo_Have_6_Items()
    {
        //arrange
        IStudentRepo repo = new FakeStudentRepo();
        //act
        var students = repo.GetStudents();
        //assert
        Assert.Equal(6, students.Count);
    }

    [Fact]
    public void Is_fakeRepo_GetStudentById_Works()
    {
        //arrange
        IStudentRepo repo = new FakeStudentRepo();
        //act
        var student = repo.GetStudent(2);
        //assert
        Assert.Equal("KLIKA", student?.LastName);
        Assert.Equal("MONIKA", student?.FirstName);
    }
    [Fact]
    public void Is_AddStudent_Increment_Id()
    {
        //arrange
        IStudentRepo repo = new FakeStudentRepo();
        var newStudent = new Student
        {
            FirstName = "Test",
            LastName = "Testowy"
        };
        //act
        repo.AddStudent(newStudent);
        var student = repo.GetStudent(7);
       
        //assert
        Assert.NotNull(student);
        Assert.Equal("TEST", student?.FirstName);
        
    }
}

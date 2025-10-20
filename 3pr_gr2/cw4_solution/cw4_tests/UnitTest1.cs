
namespace cw4_tests;
using cw4_class.Models;

using Xunit;



public class UnitTest1
{
    [Fact]
    public void Is_fakeRepo_Have_5_Items()
    {
        //arrange
        var repo = new FakeStudentRepo();

        //act
        var students = repo.GetStudents();

        //assert
        Assert.Equal(5, students.Count);
    }
}

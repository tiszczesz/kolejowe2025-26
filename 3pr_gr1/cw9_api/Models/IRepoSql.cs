using System;

namespace cw9_api.Models;

public interface IRepoSql
{
    public List<Student> GetStudents();
    public Student? GetStudent(int id);
    public void AddStudent(Student student);
    public void UpdateStudent(Student student);
    public void DeleteStudent(int id);

    // Departament
    public List<Departament> GetDepartaments();
    public void AddDepartament(Departament departament);
}

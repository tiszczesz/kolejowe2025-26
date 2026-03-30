using System;

namespace cw9_api.Models;

public class RepoSql : IRepoSql
{
    private readonly string _connectionString;
    public RepoSql(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlite") 
                ?? "Data Source=appdb.db";
    }
    public void AddDepartament(Departament departament)
    {
        throw new NotImplementedException();
    }

    public void AddStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Departament> GetDepartaments()
    {
        throw new NotImplementedException();
    }

    public Student? GetStudent(int id)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudents()
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}

using System;

namespace cw10_api.Models;

public interface IRepoSqlite
{
    public IList<User> GetUsers();
    public User? GetUser(int id);
    public void AddUser(User user);
    public void UpdateUser(User user);
    public void DeleteUser(int id);
    public IList<Role> GetRoles();
    public Role? GetRole(int id);
    public void AddRole(Role role);
}

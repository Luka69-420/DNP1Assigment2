using System.Collections.Generic;
using Models;

namespace WebApplicationAssigment.Data
{
    public interface IUserService
    {
        IList<User> GetUsers();
        User AddUser(User user);
        void RemoveUser(int userId);
    }
}
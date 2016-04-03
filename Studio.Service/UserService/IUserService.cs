using com.boutique.Entity;
using System;
using System.Collections.Generic;

namespace com.boutique.Service
{
    public interface IUserService : IDisposable
    {
        User AddUpdateUser(User user);
        User GetUserByUserName(string username, int? id);
        User GetUserByGUID(Guid guid);
        IEnumerable<User> GetAllUsers();
    }
}



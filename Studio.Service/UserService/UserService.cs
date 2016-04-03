using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using com.boutique.Entity;

namespace com.boutique.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitofWork;
       
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
            
        }

        public void Dispose()
        {
            _unitofWork.Dispose();
        }

        public User AddUpdateUser(User user)
        {
            if (user.UserId > 0)
            {
                _unitofWork.Repository<User>().Update(user);
            }
            else
            {               
                _unitofWork.Repository<User>().Insert(user);

            }
            _unitofWork.Save();
            return user;
        }
       
        public IEnumerable<User> GetAllUsers()
        {
            return _unitofWork.Repository<User>().Query().Get();
        }

        public User GetUserByGUID(Guid guid)
        {
            return _unitofWork.Repository<User>().Query().Include(x => x.boutique).Get().
                FirstOrDefault(u => u.guid == guid);
        }

        public User GetUserByUserName(string username, int? id)
        {
            return _unitofWork.Repository<User>().Query().Get().FirstOrDefault(u => u.UserName == username && (id != null || u.UserId != id));
        }

    }
}

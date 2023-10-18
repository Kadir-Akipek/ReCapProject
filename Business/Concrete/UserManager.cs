using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }
        public void Add(User user)
        {
            _userdal.Add(user);
        }

        public void Delete(User user)
        {
            _userdal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userdal.GetAll();
        }

        public User GetById(int id)
        {
            return _userdal.Get(x => x.Id == id);
        }

        public void Update(User user)
        {
            _userdal.Update(user);
        }
    }
}

using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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

        public IResult Add(User user)
        {
            _userdal.Add(user);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(User user)
        {
            _userdal.Delete(user);

            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userdal.Get(x => x.Id == id), Messages.ProductsListed);
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.ProductDeleted);
        }
    }
}

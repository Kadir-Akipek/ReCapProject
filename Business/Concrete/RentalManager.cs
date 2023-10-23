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
    public class RentalManager : IRentalService
    {
        IRentalDal _irentaldal;

        public RentalManager(IRentalDal irentaldal)
        {
            _irentaldal = irentaldal;
        }

        public IResult Add(Rental rental)
        {
            _irentaldal.Add(rental);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Rental rental)
        {
            _irentaldal.Delete(rental);

            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_irentaldal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_irentaldal.Get(x => x.Id == id), Messages.ProductsListed);
        }

        public IResult Update(Rental rental)
        {
            _irentaldal.Update(rental);

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}

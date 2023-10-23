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
    public class CarManager : ICarService
    {
        ICarDal _cardal;//DataAccess katmanına eriştik, injection

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public IResult Add(Car car)
        {
            _cardal.Add(car);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);

            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_cardal.Get(x => x.Id == id), Messages.ProductsListed);
        }

        public IDataResult<Car> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_cardal.Get(x => x.Id == id), Messages.ProductsListed);
        }

        public IDataResult<Car> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<Car>(_cardal.Get(x => x.Id == id), Messages.ProductsListed);
        }

        public IResult Update(Car car)
        {
            _cardal.Update(car);

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
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

        public void Add(Car car)
        {
            _cardal.Add(car);
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car GetById(int id)
        {
            return _cardal.Get(x => x.Id == id);
        }

        public Car GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _cardal.Update(car);//Data Acces'de başka bir değişkene atıyorduk
        }
    }
}

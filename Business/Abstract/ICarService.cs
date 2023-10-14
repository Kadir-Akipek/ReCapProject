using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetById(int id);
        Car GetCarsByBrandId(int id);
        Car GetCarsByColorId(int id);
    }
}

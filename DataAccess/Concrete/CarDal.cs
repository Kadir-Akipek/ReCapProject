using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class CarDal : ICarDal
    {
        List<Car> _cars;//liste oluşturduk
        public CarDal()//Constrcutor'lar ilk devreye giren metodlardır
        {
            _cars = new List<Car> { 
            new Car{Id = 1, BrandId = 1, ColorId = 1, DailyProper = 1, ModelYear = 2000, Description = "a"},
            new Car{Id = 2, BrandId = 1, ColorId = 1, DailyProper = 1, ModelYear = 2000, Description = "a"},
            new Car{Id = 3, BrandId = 1, ColorId = 1, DailyProper = 1, ModelYear = 2000, Description = "a"},
            new Car{Id = 4, BrandId = 1, ColorId = 1, DailyProper = 1, ModelYear = 2000, Description = "a"},
            new Car{Id = 5, BrandId = 1, ColorId = 1, DailyProper = 1, ModelYear = 2000, Description = "a"}
            };//referans verdik
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var delete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(delete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            var update = _cars.SingleOrDefault(u => u.Id == car.Id);
            update.BrandId = car.BrandId;
            update.ColorId = car.ColorId;
            update.ModelYear = car.ModelYear;
            update.DailyProper = car.DailyProper;
            update.Description = car.Description;
        }
    }
}

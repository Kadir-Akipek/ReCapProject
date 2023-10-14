using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Net;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = 1;
            car.DailyProper = 1;
            car.Description = "b";
            car.BrandId = 1;
            car.ColorId = 1;

            CarDal carDal = new CarDal();//açık mavi = imza

            Brand brand = new Brand();
            Color color = new Color();


            //carDal.Add(car);
            //carDal.Update(car);
            //carDal.Delete(car);
            //carDal.GetById(car.Id);
            var get = carDal.GetById(1);
            Console.WriteLine(get.Description);

            carDal.GetAll();

            //foreach (var c in carDal.GetAll())
            //{
            //    Console.WriteLine(c.Id);
            //    Console.WriteLine(c.Description);
            //}
        }
    }
}

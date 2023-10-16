using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<Car> GetCarDetails()
        {
            using (RecapContext context = new RecapContext())
            {
                /*var result = from c in context.Colors
                             join brand in context.Brands
                             on c.Id equals brand.Id
                             select new GetCarDetails
                             {
                                 BrandName = brand.Name, CarName = c.Name,
                                 DailyPrice = c.Price,
                                
                             };
                return result.ToList();*/
                return null;
            }
            
        }
    }
}

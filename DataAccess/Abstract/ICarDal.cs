using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>//Car'a özgü operasyonları buraya yazacağız
    {
        List<Car> GetCarDetails();
    }
}

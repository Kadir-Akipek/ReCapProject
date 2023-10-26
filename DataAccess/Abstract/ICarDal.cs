using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>//Car'a özgü operasyonları buraya yazacağız
    {
        IDataResult<List<Car>> GetCarDetails();
    }
}

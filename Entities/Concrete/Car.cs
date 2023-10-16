using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Car:IEntity//Tables
    {
        //Columns
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Günlük fiyat 0'dan büyük olmalıdır.")]
        public int DailyProper { get; set; }
        
        
        public string Description { get; set; }

    
    }
}

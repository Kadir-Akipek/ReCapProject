using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        [MinLength(2, ErrorMessage = "Araba ismi 2 karakterden aşağı olamaz")]
        public string Name { get; set; }

    }
}

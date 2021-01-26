using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    abstract class BasicInfo : IBasicInfo
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string NationalityId { get; set; }
        public virtual double Price { get; set; }
        public virtual double Discount { get; set; }
    }
}

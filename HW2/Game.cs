using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Game:BasicInfo
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Price { get; set; }
        public override double Price { get => base.Price; set => base.Price = value; }
    }
}

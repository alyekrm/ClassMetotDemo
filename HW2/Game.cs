using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Game:IBasicInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

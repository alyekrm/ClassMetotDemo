﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Gamer : IBasicInfo
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalityId { get; set; }
    }
}

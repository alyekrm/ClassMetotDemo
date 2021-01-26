using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Gamer : BasicInfo
    {

        public override string Surname { get => base.Surname; set => base.Surname = value; }
        public override string NationalityId { get => base.NationalityId; set => base.NationalityId = value; }

    }
}

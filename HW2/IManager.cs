using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    interface IManager
    {
        void Add(IBasicInfo basicInfo);
        void Delete(IBasicInfo basicInfo);
        void Update(IBasicInfo basicInfo);
    }
}

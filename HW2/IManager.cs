using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    interface IManager
    {
        
        void Add(IBasicInfo basicInfo,List<IBasicInfo> dataBase);
        void Delete(IBasicInfo basicInfo, List<IBasicInfo> dataBase);
        void Update(IBasicInfo basicInfo, List<IBasicInfo> dataBase);
        void List(List<IBasicInfo> dataBase);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    interface IManager
    {
        
        void Add(BasicInfo basicInfo,List<BasicInfo> dataBase);
        void Delete(BasicInfo basicInfo, List<BasicInfo> dataBase);
        void Update(BasicInfo basicInfo, List<BasicInfo> dataBase);
        void List(List<BasicInfo> dataBase);
    }
}

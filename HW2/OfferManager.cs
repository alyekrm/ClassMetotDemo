using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class OfferManager : IManager
    {
        public void Add(IBasicInfo basicInfo)
        {
            Console.WriteLine("Id numarası "+basicInfo.Id+" olan indirim tanımlandı.");
        }

        public void Delete(IBasicInfo basicInfo)
        {
            Console.WriteLine("Id numarası " + basicInfo.Id + " olan indirim iptal edildi.");
        }

        public void Update(IBasicInfo basicInfo)
        {
            Console.WriteLine("Id numarası " + basicInfo.Id + " olan indirim düzenlendi.");
        }
    }
}

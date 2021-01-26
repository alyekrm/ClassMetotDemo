using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Manager : IManager
    {

        public void Add(IBasicInfo basicInfo, List<IBasicInfo> dataBase)
        {
            dataBase.Add(basicInfo);
            Console.WriteLine("Id numarası " + basicInfo.Id + " olarak tanımlandı.");
        }

        public void Delete(IBasicInfo basicInfo, List<IBasicInfo> dataBase)
        {
            foreach (var item in dataBase)
            {
                if (item.Id == basicInfo.Id)
                {
                    dataBase.Remove(basicInfo);
                    Console.WriteLine("{0} listeden silindi",basicInfo.Id);
                }

            }
            Console.WriteLine("Id numarası " + basicInfo.Id + " olan indirim iptal edildi.");
        }

        public void List(List<IBasicInfo> dataBase)
        {
            foreach (var item in dataBase)
            {
                Console.WriteLine(item.Id+" "+item.Name);
                
            }
            
        }


        public void Update(IBasicInfo basicInfo, List<IBasicInfo> dataBase)
        {
            foreach (var item in dataBase)
            {
                if (item.Id == basicInfo.Id)
                {
                    Console.WriteLine("Yeni ismi giriniz");
                    string oldName = item.Name;
                    item.Name = Console.ReadLine();
                    Console.WriteLine("{0} listeden {1} olarak değiştirildi silindi",oldName, basicInfo.Id);
                }
                else
                {
                    Console.WriteLine("veri bulunamadı");
                }

            }
            
        }

    }
}

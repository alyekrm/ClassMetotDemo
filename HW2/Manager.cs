using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Manager : IManager
    {

        public void Add(BasicInfo basicInfo, List<BasicInfo> dataBase)
        {
            dataBase.Add(basicInfo);
            Console.WriteLine("Id numarası " + basicInfo.Id + " olarak tanımlandı.");
        }

        public void Delete(BasicInfo basicInfo, List<BasicInfo> dataBase)
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

        public void List(List<BasicInfo> dataBase)
        {
            foreach (var item in dataBase)
            {
                Console.WriteLine(item.Id+" "+item.Name+" " +item.NationalityId+" "+item.Price+" " +item.Surname);
                
            }
            
        }


        public void Update(BasicInfo basicInfo, List<BasicInfo> dataBase)
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

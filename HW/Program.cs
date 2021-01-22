using System;
using System.Collections.Generic;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Locate elma = new Locate();
            elma.Id = 1;
            elma.Name = "elma";
            elma.Category = "meyve";
            elma.Location = "Amasya";
            
            Locate ceviz = new Locate {Id=1,Name = "ceviz", Category = "kuruyemiş" };
          
            ceviz.Location = "kayseri";
 
            Locate karpuz = new Locate("diyarbakır");
            karpuz.Id = 3;
            karpuz.Name = "karpuz";
            karpuz.Category = "meyve";

            MyDictionary<int,Locate> mydictionary = new MyDictionary<int,Locate>();
            mydictionary.Add(10,karpuz);
            mydictionary.Add(20,ceviz);
            mydictionary.Add(30,elma);


            int[] A = mydictionary.Keys;
            Locate[] B = mydictionary.Values;
            Console.WriteLine("key Id Name  Category Geldiği Yer");
            for (int i = 0; i < A.Length; i++)
            {
 
                Console.WriteLine(A[i]+"  " +(B[i].Id)+" "+" "+ (B[i].Name) + " " + (B[i].Category) + " "+(B[i].Location) );

            }
            
            


        }
    }
}

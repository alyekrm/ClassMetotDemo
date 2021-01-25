using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class GamerManager : IManager
    {

        private IValidation _validation;

        public GamerManager(IValidation validation)
        {
            _validation = validation;
        }

        public void Add(IBasicInfo basicInfo)
        {
            if (_validation.Validate(basicInfo))
            {
                Console.WriteLine(basicInfo.Name + " kullanıcı adıyla "+basicInfo.Id+" id numarası ile sisteme eklendi.");
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }

        public void Delete(IBasicInfo basicInfo)
        {
            Console.WriteLine(basicInfo.Id + "id numaralı kullanıcı adi sistemden silindi.");
        }

        public void Update(IBasicInfo basicInfo)
        {
            Console.WriteLine(basicInfo.Id + " id numaralı kullanıcı verileri güncellendi.");
        }
    }
   
}

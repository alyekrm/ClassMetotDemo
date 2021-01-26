using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class GamerManager : Manager
    {
      
        
        private IValidation _validation;

        public GamerManager(IValidation validation)
        {
            _validation = validation;
        }

        public void Add(IBasicInfo basicInfo, List<IBasicInfo> dataBase)
        {
            if (_validation.Validate(basicInfo))
            {
                Console.WriteLine(basicInfo.Name + " kullanıcı adıyla "+basicInfo.Id+" id numarası ile sisteme eklendi.");
                dataBase.Add(basicInfo);
            }
            else
            {
                throw new NotImplementedException();
            }            
        }

     
    }
   
}

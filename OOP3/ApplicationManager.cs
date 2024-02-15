using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplicationManager
    {
       //Method injection 

        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuru bilgilerini değerlendirme 

            creditManager.Calculate();
            loggerService.Log();
          
        }
        public void GiveCreditPreliminaryInformation(List<ICreditManager> credits) //Kredi ön bilgilendirmesi yap
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

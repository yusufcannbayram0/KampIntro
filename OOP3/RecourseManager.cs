using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        public void DoRecourse(ICreditManager creditmanager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            
            creditmanager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void DoCreditPrenotification(List<ICreditManager> credits )
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

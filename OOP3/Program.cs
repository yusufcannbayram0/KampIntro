using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        // interface'ler de o interface'i implemente eden class'ın referans numarasını tutar
        static void Main(string[] args)
        {
            // ekrandaki kullanılabilecek krediler
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager residenceCreditManager = new ResidenceCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, new SmsLoggerService()};

            // Başvuru
            RecourseManager recourseManager = new RecourseManager();
            recourseManager.DoRecourse(new EsnafCreditManager(),loggers);



            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,transportCreditManager};

            //recourseManager.DoCreditPrenotification(credits);

        }
    }
}

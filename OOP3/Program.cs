using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //veya IhtıyacKrediManager yaz IkrediBase yerine 
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager(); 
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            IloggerService databaseLoggersevice = new DataBaseLoggerService();
            IloggerService fileLoggerservice = new FileLoggerService();


            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerservice);

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() { ihtiyacKrediManager, tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYAp(krediler);



        }

    }
}

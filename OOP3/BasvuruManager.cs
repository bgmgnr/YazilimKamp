using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediBaseManager krediBaseManager, IloggerService loggerService )//Ikredi hepsini tutuyordu. Başvurular için bağımsız seçilebilir
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla(); 
            //çalışır ama tüm başvurular konut kredisine bağlandı.dıt.
            krediBaseManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYAp(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}

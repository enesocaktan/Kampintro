using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {// Method İnjection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran Bİlgilerini Değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Eğer böyle yaparsak bütün kredileri konutkredisi olarak alır
          
           krediManager.Hesapla();
           //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

           }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
//interfaceleri biribirinin alternatifi olan ama türü farklı olan alanlar için kullanılırız..
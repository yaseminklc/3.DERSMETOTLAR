using OOP3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKrediManager(), new  List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
           
        
        
        //databaseloggerservice olunca veritabanına loglandı
        //filelogger service olsaydı dosyaya loglandı diyecekti.
       
        List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager,ıhtiyacKrediManager};
        List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService() };
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }
}
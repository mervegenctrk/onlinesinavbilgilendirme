using System;

namespace onlinesinavbilgilendirme.arkaplan
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var shouldContinue = true;
            do
            {
                //Insert to DB if not exist
                DataHelpers.DuyuruCekDuzce();
                DataHelpers.DuyuruCekAnadolu();
                DataHelpers.DuyuruCekOsym();

                System.Threading.Thread.Sleep(5 * 60 * 1000);
            } while (shouldContinue);
        }
    }
}

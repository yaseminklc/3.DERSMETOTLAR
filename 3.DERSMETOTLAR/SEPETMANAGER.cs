using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DERSMETOTLAR
{
    internal class SepetManager
    {
        public void Ekle( Product product)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + product.Adi );

        }
         
        public void Ekle2(string productAdi , string aciklama, double fiyat, double StokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + productAdi);
        }


    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi: " + product.Adi);
        }

        //Tercih edilmez bu çok
        public void Ekle2(string productName, string Aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi: "+ productName);
        }

    }
}

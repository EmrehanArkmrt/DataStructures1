using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Stack{            
        
        private int büyüklük;               //yığın için dizi ve gerekli değişkenleri oluşturma
        private Müşteri[] YıgınListe;
        private int Top;

        public Stack(int büyüklük)  //büyüklük değerini alan ve yığını için diziyi oluşturan yapılandırıcı metod
        {

            this.büyüklük = büyüklük;
            YıgınListe = new Müşteri[büyüklük];
            Top = -1;
        }
        public Stack()  //büyüklük değerini almadan ve yığını için diziyi oluşturan yapılandırıcı metod
        {
            
            YıgınListe = new Müşteri[büyüklük];
            Top = -1;
        }


        public void Push(Müşteri a) //yığının üstüne eleman ekleyen metod
        {
            YıgınListe[++Top] = a;
        }

        public Müşteri Pop()    //yığından LIFO olacak şekilde eleman çıkaran ve onu döndüren metod
        {
            return YıgınListe[Top--];
        }

        public bool BosMu(){    //yığının boş olup olmadığını kontrol eden metod

            return Top ==-1;
        }

        public void YıgınOluştur()  // yığını oluşturan ve LIFO olacak şekilde elemanları çıkarıp döndüren metod
        {
            
            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            Stack yıgın = new Stack(veri1.Length);
            for(int i=0;i<veri1.Length;i++)
            {
                Müşteri geçici = new Müşteri(veri1[i], veri2[i]);
                yıgın.Push(geçici);
            }

            

            while (!yıgın.BosMu())
            {
                Console.WriteLine(yıgın.Pop());

            }
            
            
        }

    }




}


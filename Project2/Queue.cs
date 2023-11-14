using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Queue
    {
        private int büyüklük;           
        private Müşteri[] kuyrukListe;      //gerekli dizi ve değişkenler oluşturuluyor
        private int baş;
        private int son;
        private int elemansayısı;

        public Queue(int büyüklük)  //büyüklük değerini alan ve kuyruk yapısı için dizi yi oluşturan yapılandırıcı metod
        {
            this.büyüklük = büyüklük;
            kuyrukListe = new Müşteri[büyüklük];
            baş = 0;
            son = -1;
            elemansayısı = 0;

        }

        public Queue()  //büyüklük değerini almadan ve kuyruk yapısı için dizi yi oluşturan yapılandırıcı metod
        {            
            kuyrukListe = new Müşteri[büyüklük];
            baş = 0;
            son = -1;
            elemansayısı = 0;
        }

        public void Ekle(Müşteri a) //kuyruk yapısının sonuna ekleme yapan metod
        {
            if (son == büyüklük - 1)
            {
                son = -1;
                
            }
            kuyrukListe[++son] = a;
            elemansayısı++;

        }

        public Müşteri Çıkar()  //kuyruk yapısından FIFO olacak şekilde eleman çıkaran ve değer döndüren metod
        {
            Müşteri temp = kuyrukListe[baş++];
            if (baş == büyüklük)
            {

                baş = 0;
            }
            elemansayısı--;
            return temp;
        }

        public bool BosMu()       //kuyruk yapısının boş olup olmadığını kontrol eden metod  
        {

            return (elemansayısı == 0);
        }

        public void KuyrukOluştur() // kuyruğu oluşturan ve FIFO olacak şekilde elemanları çıkaran ve döndüren metod
        {
            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            Queue k = new Queue(veri1.Length);

            for (int i = 0; i < veri1.Length; i++)
            {
                Müşteri geçici = new Müşteri(veri1[i], veri2[i]);
                k.Ekle(geçici);
            }

            while (!k.BosMu())
            {
                Console.WriteLine(k.Çıkar());
            }

        }

        public float İşlemSüresi() {    //ortalama işlem süresini oluşturmak için kuyruk yapısını oluşturan ve işlem süresini döndüren metod
            

            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            Queue k = new Queue(veri1.Length);
            int[] işlemsüresi = new int[veri2.Length];
            int[] işlemsüresi2 = new int[veri2.Length];
            int süre = 0;
            for (int i = 0; i < veri1.Length; i++)
            {
                Müşteri geçici = new Müşteri(veri1[i], veri2[i]);
                k.Ekle(geçici);

            }

            for (int i = 0; i < veri2.Length; i++)
            {
                işlemsüresi[i] = k.Çıkar().ÜrünSayısı1;                    

            }

            for (int i = 0; i < veri2.Length; i++)
            {
                if (i == 0)
                {
                    işlemsüresi2[i] = işlemsüresi[i];

                }
                else
                {
                    işlemsüresi2[i] = işlemsüresi[i] + işlemsüresi2[i - 1];
                }

            }
            for(int i = 0; i < veri2.Length; i++){

                süre += işlemsüresi2[i];

            }           
             
            return (float)süre /işlemsüresi2.Length;


        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class PQueue
    {
        
        private List<Müşteri> kuyrukListe;  //alt yapıda veri tutmak için list veri yapısı oluşturuluyor
        private int elemansayısı; 

        public PQueue() //listeyi oluşturan yapılandırıcı
        {

            kuyrukListe = new List<Müşteri>();                        
            elemansayısı = 0;

        }

        public void Ekle(Müşteri a) //kuyruk yapısına eleman ekleyen metod
        { 

            kuyrukListe.Add(a);            
            elemansayısı++;

        }

        public  Müşteri ÇıkarBüyük()  //kuyruk yapısından ilk önce büyük yani azalan sırada eleman çıkarıp değer döndüren metod
        {
            int index = 0;
            Müşteri geçici = new Müşteri();
            geçici = kuyrukListe[0];
            for (int x= 0;x < kuyrukListe.Count;x++)
            {

                if (kuyrukListe[x].ÜrünSayısı1 > geçici.ÜrünSayısı1)
                {
                    index = x;
                    geçici = kuyrukListe[x];
                    

                }             
                
            }
            kuyrukListe.RemoveAt(index);
            elemansayısı--;
            return geçici;       
            
        }

        public Müşteri ÇıkarKüçük() //kuyruk yapısından ilk önce küçük yani artan sırada eleman çıkarıp değer döndüren metod
        {
            int index = 0;
            Müşteri geçici = new Müşteri();
            geçici = kuyrukListe[0];
            for (int x = 0; x < kuyrukListe.Count; x++)
            {

                if (kuyrukListe[x].ÜrünSayısı1 < geçici.ÜrünSayısı1)
                {
                    index = x;
                    geçici = kuyrukListe[x];

                }

            }
            kuyrukListe.RemoveAt(index);
            elemansayısı--;
            return geçici;

        }

        public bool BosMu() // kuyruk yapısının boş olup olmadığını kontrol eden metod
        {  

            return (elemansayısı == 0);

        }


        public void KuyrukOluşturBüyük()    //kuyruk yapısını oluşturup azalan sırada çıkaran metod 
        {
            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            PQueue k = new PQueue();

            for (int i = 0; i < veri1.Length; i++)
            {
                Müşteri eleman = new Müşteri(veri1[i], veri2[i]);
                k.Ekle(eleman);
            }

            while (!k.BosMu())
            {
                Console.WriteLine(k.ÇıkarBüyük());
            }            

        }

        public void KuyrukOluşturKüçük()  //kuyruk yapısını oluşturup artan sırada çıkaran metod
        {
            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            PQueue k = new PQueue();

            for (int i = 0; i < veri1.Length; i++)
            {
                Müşteri eleman = new Müşteri(veri1[i], veri2[i]);
                k.Ekle(eleman);
            }

            while (!k.BosMu())
            {
                Console.WriteLine(k.ÇıkarKüçük());
            }

        }


        public float İşlemSüresi()  //yazdırma işlemini kuyruktan çıkararak yaptığımız için ortalama işlen süresini hesaplamak için kuyruğu oluşturan ve süreyi hesaplayan metod
        {


            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            PQueue k = new PQueue();
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
                işlemsüresi[i] = k.ÇıkarKüçük().ÜrünSayısı1;

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
            for (int i = 0; i < veri2.Length; i++)
            {

                süre += işlemsüresi2[i];

            }
            return (float)süre / işlemsüresi2.Length;


        }


    }
}

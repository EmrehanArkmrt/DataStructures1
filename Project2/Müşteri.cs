using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Müşteri  //müşteri sınıfı
    {
        public Müşteri(string MüşteriAdı, int ÜrünSayısı)       //yapılandırıcı metod
        {
            this.MüşteriAdı = MüşteriAdı;
            this.ÜrünSayısı = ÜrünSayısı;

        }
        public Müşteri()    // boş yapılandırıcı metod 
        {
        }

        public override string ToString()  //tostring, get ve set 
        {
            return "Müşteri Adı:" + MüşteriAdı + "\tÜrün Sayısı:" + ÜrünSayısı;
        }


        private string MüşteriAdı;
        private int ÜrünSayısı;

        public string MüşteriAdı1 { get => MüşteriAdı; set => MüşteriAdı = value; }
        public int ÜrünSayısı1 { get => ÜrünSayısı; set => ÜrünSayısı = value; }

        public void DizileriOluştur()       // Bileşik veri yapısını oluşturup çıktı olarak içerdiği generic listleri sırayla yazdıran metod

        {
            int kontrol = 0;            
            Random rastgele = new Random();
            ArrayList Analiste = new ArrayList();
            string[] veri1 = { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", " Songül", "Nuri", "Deniz" };
            int[] veri2 = { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };
            for (int i = 0; i < veri1.Length; i++)
            {
                int sayac = 0;
                int randomsayı = rastgele.Next(1, 6);
                
                List<Müşteri> generic = new List<Müşteri>();
                for (int a = 0; a < randomsayı; a++)
                {

                    generic.Add(new Müşteri(veri1[kontrol + a], veri2[kontrol + a]));
                    sayac++;
                    if (kontrol + a + 1 == veri1.Length) break;                  

                }
                kontrol += sayac;
                Analiste.Add(generic);
                if (kontrol == veri1.Length) break;
            }

            int dizi = 1;

                for(int i = 0; i < Analiste.Count; i++)
                {
                    Console.Write(dizi + ". Dizi\t\t");
                    dizi++;                    

                }
                Console.WriteLine("");
                for (int i = 0; i < 5; i++)
                {

                    foreach (List<Müşteri> x in Analiste)
                    {

                        if (x.Count <= i)
                    {
                        Console.Write("\t\t");
                    }
                    
                    else
                    {
                        Console.Write(x[i].MüşteriAdı + ", " + x[i].ÜrünSayısı+"        ");                        
                       
                    }
                      
                    }
                    Console.WriteLine("");


                }
            Console.WriteLine("*********************************************************************");

            Console.WriteLine("\nDinamik Dizi Eleman Sayısı: " + Analiste.Count);
            Console.WriteLine("\nOrtalama Eleman Sayısı: " + kontrol / Analiste.Count);

           

        }


       






}




    


}

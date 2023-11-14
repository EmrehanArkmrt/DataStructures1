using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Müşteri müşteri1 = new Müşteri();
            Stack yeniyıgın = new Stack();
            Queue yenikuyruk = new Queue();
            PQueue öncelikli = new PQueue(); 

            müşteri1.DizileriOluştur();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("*********************************************************************\n");
            Console.WriteLine("Yığın Yapısı(LIFO)\n");
            yeniyıgın.YıgınOluştur();
            Console.WriteLine("*********************************************************************\n");
            Console.WriteLine("Kuyruk Yapısı(FIFO)\n");
            yenikuyruk.KuyrukOluştur();
            Console.WriteLine("*********************************************************************\n");
            Console.WriteLine("Öncelikli Kuyruk Yapısı(Azalan Sırada)\n");
            öncelikli.KuyrukOluşturBüyük();            
            Console.WriteLine("*********************************************************************\n");
            Console.WriteLine("Öncelikli Kuyruk Yapısı(Artan Sırada)\n");
            öncelikli.KuyrukOluşturKüçük();
            Console.WriteLine("*********************************************************************\n");
            Console.WriteLine("Kuyruk Yapısı için ortalama işlem tamamlanma süresi:"+yenikuyruk.İşlemSüresi());
            Console.WriteLine("*********************************************************************\n");
            Console.WriteLine("Öncelikli Kuyruk Yapısı için ortalama işlem tamamlanma süresi:" + öncelikli.İşlemSüresi());
            Console.ReadKey();




        }
    }
}

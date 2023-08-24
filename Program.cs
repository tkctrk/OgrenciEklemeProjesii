using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Listesi_Olusturma_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ogrencisayisi = 1;
            int no = 20;
            string control = "";

            List<Ogrenciler> list = new List<Ogrenciler>();

            while (control !="t")
            {
                try
                {
                    Ogrenciler ogrenc = new Ogrenciler();

                    Console.WriteLine(ogrencisayisi + ".LÜTFEN ÖĞRENCİNİN ADINI GİRİNİZ");

                    ogrenc.Name = Console.ReadLine();

                    Console.WriteLine(ogrencisayisi + ".LÜTFEN ÖĞRENCİNİN SOYADINI GİRİNİZ");

                    ogrenc.LastName = Console.ReadLine();

                    ogrenc.No = no;

                    list.Add(ogrenc);

                    ogrencisayisi++;

                    Console.WriteLine("İŞLEMİ BİTİRMEK İSTİYORSANIZ 't' BASINIZ DEVAM ETMEK İÇİN İSE 'e' BASINIZ");          
                    
                    control = Console.ReadLine().ToLower();



                    Console.Clear();


                }
                catch (Exception)
                {

                    Console.WriteLine("HATALI BİR TUŞLAMA YAPTINIZ.");
                }               
            }
            Console.WriteLine("İŞLEMİ SONLANDIRDINIZ");
            Console.WriteLine("KAYIT GERÇEKLEŞİLEN ÖĞRENCİLERİN LİSTESİ AŞAĞIDADIR.");
            foreach (Ogrenciler o in list)
            {
                Console.WriteLine("OGRENCİ ADI : {0}  SOYADI : {1}", o.Name, o.LastName);

            }
            Console.ReadKey();
        }
    }
}


namespace Method
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
          
            //islem: Class ismi
            // i1: Nesne (Object) ismi
            // new: Bellekte yeni bir yer aç anlamında
            // islem(): Constructor (Yapıcı Metot)
        
            //nesne, sınıfın bir örneğidir. instance

       
            
            string arda_adi_ = "arda";
            string arda_soyadi = "bilen";

            string elif_adi = "elif";
            string elif_soyadi = "kağba";
            islem1 o3;
            islem1 o1=new islem1();//sınıfın nesnesinin tanımlanması
            o1.adi= "arda";
            o1.soyadi = "bilen";

            islem1 o2 = new islem1();
            o2.adi = "elif";
            o2.soyadi = "kağba";


            islem1 o4;// bellekte yeri ayrılmamış;
            o4 = o2; // bellekte yeri ayrılmış nesneye referans ataması yapıldı.

            Toplam(5, 10);
            Toplam(5, 10,45);
            Toplam(5, 10, 45,-1000);
            Toplam(5, 10, 45,30,250,5000);

            
        }
        
        
        static void Toplam(params int[] a)
        {   
            int sonuc = 0;
            EkranaYazdir(sonuc);
            for (int i = 0; i < a.Length; i++)
            {
                sonuc += a[i];
            }
            EkranaYazdir(sonuc);

            void EkranaYazdir(int deger)
            { //Local Function
                Console.WriteLine("Toplam Sonucu: " + deger);
            }
        }
       

    }
  
}

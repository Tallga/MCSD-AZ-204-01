using System;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable metodunu tetiklemek için kullanıır.
            //Variable();
            
            //People Class bilgisinden yeni bir kayıt oluşturur.
            People people = new People();
            

            //Parantez içerisindeki ifadeyi ekrana yazar. İmleci ifadenin sonunda bekletir.
            Console.Write("Merhaba ilk uygulama!");
            //Parantez içersindeki ifadeyi ekrana yazar. İmleci ifadenin alt satırında bekletir.
            Console.WriteLine("Merhaba WorkSpace!");

            //Kullanıcıdan bir yanıt bekler.
            Console.ReadLine();
        }

        private static void Variable()
        {
            //String veri tipi içerinde yazısal ifadeler saklar.
            string message = "Merhaba Dünya!";
            //Double veri tipi içerisine ondalık ifadeler saklar.
            double money = 100000; //Veritabanında gelecek.
            
            //Bu tek satırlık bir açıklama satırıdır.
             /*
             Bu 1. açıklama satırıdır.
             Bu 2. açıklama satırıdır.
             Bu 3. açıklama satırıdır.
             */            

            //Integer veri tipi içerisinde sadece tam sayı ifadeler saklar.
            int accountBalance = 99;
            
            //Boolean veri tipi içerisinde sadece true ve false değerleri saklar.
            bool isLogin = true;
            bool isCompleted = false;
            string welcomeMessage = "WorkSpace uygulamasına hoşgeldiniz.";


            string name = "Fatih";
            string surname = "Soysal";
            int birthYear = 1970;


            long TCNumber = 12345678900;



            // Console.WriteLine: Satır içerisine parantez içerisindeki bölümü yazar. Ve alt satıra iner.
            //Console.WriteLine(1000 * 1.92);
            //Console.WriteLine(money * 1.92);
        }
    }

    
    //Public class tipi class'ın farklı noktalardan erişilebilir olmasını sağlar.
    public class People
    {
        
        //public string name = "Fatih";

        //public string surname = "Soysal";
        //public int birthDate = 1970;
        //public long TCNumber = 12345678900;

        //Class içerisindeki attribute bilgilerini oluşturuyoruz.
        //Public olarak dışarıdan Set edilebilir, Veya içeriden get edilebilir durumda olacaklar.
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public long TcNumber { get; set; }

    }


}

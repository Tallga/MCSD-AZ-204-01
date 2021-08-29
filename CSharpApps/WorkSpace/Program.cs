using System;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable();
            People people = new People();
            
            Console.ReadLine();
        }

        private static void Variable()
        {
            string message = "Merhaba Dünya!";
            double money = 100000; //Veritabanında gelecek.
            //Bu tek satırlık bir açıklama satırıdır.

             /*
             Bu 1. açıklama satırıdır.
             Bu 2. açıklama satırıdır.
             Bu 3. açıklama satırıdır.
             */            

            int accountBalance = 99;
            bool isLogin = true;
            bool isCompleted = false;
            string welcomeMessage = "WorkSpace uygulamasına hoşgeldiniz.";


            string name = "Fatih";
            string surname = "Soysal";
            int birthYear = 1970;
            long TCNumber = 12345678900;




            //Console.WriteLine(1000 * 1.92);
            //Console.WriteLine(money * 1.92);
        }
    }

    public class People
    {
        //public string name = "Fatih";
        //public string surname = "Soysal";
        //public int birthDate = 1970;
        //public long TCNumber = 12345678900;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public long TcNumber { get; set; }

    }


}

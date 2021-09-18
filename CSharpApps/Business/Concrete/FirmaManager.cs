using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FirmaManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public FirmaManager(IApplicantService applicantService) //Constructor new tetiklendiğinde çalışan kısım
        {
            _applicantService = applicantService;

        }
        public void GiveData(Person person)
        {
            
            if (_applicantService.checkPerson(person)) //true ya da false
            {
              //Eşitlik sağlandığı durumda çalışacak blok buraya yazılır.
              Console.WriteLine(person.FirstName + " " + person.LastName + " geçerli bir vatandaş bilgisine sahiptir");
            }
            else
            {
                //Eşitlik sağlanmadığ durumda çalışacak blok buraya yazılır.
                Console.WriteLine(person.FirstName + " " + person.LastName + " geçerli bir vatandaş bilgisine sahip değildir");
            }



        }


    }
}

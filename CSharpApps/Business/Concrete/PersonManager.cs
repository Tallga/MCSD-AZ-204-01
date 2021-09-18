using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {

        public void Apply(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

         public bool checkPerson(Person person)
         {
            //Kontrol yapılacak.,
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            //Gönderilecek parametreler;
            //TCKimlikNo, Ad, Soyad, DogumYili
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody
                    (person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
         }
    }
}

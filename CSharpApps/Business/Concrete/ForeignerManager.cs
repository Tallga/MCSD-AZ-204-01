using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService 
    {
        public void Apply(PersonManager person)
        {
            throw new NotImplementedException();
        }
        public bool checkPerson(PersonManager person)
        {
            throw new NotImplementedException();
        }

        public bool checkPerson(Person person)
        {
            throw new NotImplementedException();
        }

        
    }
}

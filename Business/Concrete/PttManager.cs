using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantServices _applantServices;

        public PttManager(IApplicantServices applicantServices) // Constructor new yapıldığında çalışır
        {
            _applantServices = applicantServices;
        }
        public void GiveMask(Person person)
        {
            
            if(_applantServices.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
        }
    }
}

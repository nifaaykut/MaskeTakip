// See https://aka.ms/new-console-template for more information




using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "NİFA";
person1.LastName = "AYKUT";
person1.NationalIdentity = 123456789;
person1.DateOfBirthYear = 1993;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();






using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Person
    {
        public string Name;
        public string Surname;
        public string PhoneNumber;

        public Person()
        {
            Console.WriteLine("Please enter name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Please enter surname: ");
            string surname=Console.ReadLine();
            Console.WriteLine("Please enter phone number: ");
            string phoneNumber=Console.ReadLine();
            this.Name=name;
            this.Surname=surname;
            this.PhoneNumber=phoneNumber;
        }

        public void AddPerson(List<Person>dataBase,Person newPerson){
            dataBase.Add(newPerson);
        }
        public static void RemovePerson(List<Person>dataBase,string personQuery){
            int listCount=dataBase.Count;
            Person toBeRemoved=null;
            foreach (Person personToBeRemoved in dataBase)
            {
            if(personToBeRemoved.Name==personQuery)
                toBeRemoved=personToBeRemoved;
            else if(personToBeRemoved.Surname==personQuery)
                toBeRemoved=personToBeRemoved;
            else if(personToBeRemoved.PhoneNumber==personQuery)
                toBeRemoved=personToBeRemoved;
            }
            if (dataBase.Contains(toBeRemoved))
                dataBase.Remove(toBeRemoved);
            if (dataBase.Count!=listCount)
                Console.WriteLine("Removal is successfull");
            else
                Console.WriteLine("The person is not on the phone book.");
        }
        public static void UpdatePerson(List<Person> dataBase,string personQuery){
            List<Person> listCount=dataBase;
            Person toBeUpdated=null;
            foreach (Person personToBeUpdated in dataBase)
            {
            if(personToBeUpdated.Name==personQuery)
                toBeUpdated=personToBeUpdated;
            else if(personToBeUpdated.Surname==personQuery)
                toBeUpdated=personToBeUpdated;
            else if(personToBeUpdated.PhoneNumber==personQuery)
                toBeUpdated=personToBeUpdated;
            }
            if (dataBase.Contains(toBeUpdated)){
                dataBase.Remove(toBeUpdated);
                Person updatedPerson = new Person();
                dataBase.Add(updatedPerson);
            }
            if (dataBase!=listCount)
                Console.WriteLine("Update is successfull");
            else
                Console.WriteLine("The person is not on the phone book.");
        }
        public static void SortPhoneBook(List<Person>dataBase,string order){
            List<string> sortedDataBase = new List<string>();
            foreach (var item in dataBase)
            {
                sortedDataBase.Add(item.Name);
                sortedDataBase.Sort();   
            }
            if (order=="z-a")
                sortedDataBase.Reverse();
            Console.WriteLine("Phone Book");
            Console.WriteLine("****************************");
            foreach (var persona in sortedDataBase)
                    {
                        foreach (var item in dataBase)
                        {
                            if (persona==item.Name)
                            {Console.WriteLine("İsim             : "+item.Name);
                            Console.WriteLine("Soyisim          : "+item.Surname);
                            Console.WriteLine("Telefon Numarası : "+item.PhoneNumber);}
                        }
                        Console.WriteLine(" - ");
                    }
        }
        public static void FindOnPhoneBook(List<Person>dataBase,string personQuery){
            List<string> personquery= new();
            Console.WriteLine("****************************");
            Console.WriteLine("Found Person");
            foreach (var item in dataBase)
            {
                personquery.Add(item.Name);
                personquery.Add(item.Surname);
                personquery.Add(item.PhoneNumber);
                if (item.Name==personQuery)
                {
                    Console.WriteLine("İsim             : "+item.Name);
                    Console.WriteLine("Soyisim          : "+item.Surname);
                    Console.WriteLine("Telefon Numarası : "+item.PhoneNumber);
                    Console.WriteLine(" - ");
                }
                else if (item.Surname==personQuery)
                {
                    Console.WriteLine("İsim             : "+item.Name);
                    Console.WriteLine("Soyisim          : "+item.Surname);
                    Console.WriteLine("Telefon Numarası : "+item.PhoneNumber);
                    Console.WriteLine(" - ");
                }
                else if (item.PhoneNumber==personQuery)
                {
                    Console.WriteLine("İsim             : "+item.Name);
                    Console.WriteLine("Soyisim          : "+item.Surname);
                    Console.WriteLine("Telefon Numarası : "+item.PhoneNumber);
                    Console.WriteLine(" - ");
                }
            }
            if(personquery.Contains(personQuery)==false)
                Console.WriteLine("Person not on phonebook");
        }
    }
}
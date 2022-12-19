using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person>PhoneBook = new List<Person>();
            start:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("******************************************");
            Console.WriteLine("(1) Yeni numara kaydetmek");
            Console.WriteLine("(2) Varolan numarayı silmek");
            Console.WriteLine("(3) Varolan numarayı güncellemek");
            Console.WriteLine("(4) Rehberi listelemek");
            Console.WriteLine("(5) Rehberde arama yapmak");
            
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Person newPerson = new Person();
                    newPerson.AddPerson(PhoneBook,newPerson);
                    break;
                case 2:
                    Console.WriteLine("Who do you want to remove?");
                    string personQuery=Console.ReadLine();
                    Person.RemovePerson(PhoneBook,personQuery);
                    break;
                case 3:
                    Console.WriteLine("Who do you want to update?");
                    personQuery=Console.ReadLine();
                    Person.UpdatePerson(PhoneBook,personQuery);
                    break;
                case 4:
                    Console.WriteLine("In which order do you want to sort the phone book? ('a-z' / 'z-a')");
                    string order=Console.ReadLine();
                    Person.SortPhoneBook(PhoneBook,order);
                    break;
                case 5:
                    Console.WriteLine("Who do you want to find?");
                    personQuery=Console.ReadLine();
                    Person.FindOnPhoneBook(PhoneBook,personQuery);
                break;
            }
            
            // Final işlemi ve kapanış
            Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? ( 1 - Evet , 2 - Hayır)");
            int repeat=int.Parse(Console.ReadLine());
            if (repeat==1)
            goto start;
            else
                Console.WriteLine("İşlem tamamlandı.");
            Console.ReadLine();
        }
    }
}

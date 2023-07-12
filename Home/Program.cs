using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

namespace Home
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }


     public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            personList.Add(new Person { Name = "Azad", Surname = "Ibrahimli", Age = 31 });
            personList.Add(new Person { Name = "Azad", Surname = "Ibrahimli", Age = 31 });
            personList.Add(new Person { Name = "Azad2", Surname = "Ibrahimli", Age = 31 });
            personList.Add(new Person { Name = "Azad3", Surname = "Ibrahimli33", Age = 31 });
            personList.Add(new Person { Name = "Azad4", Surname = "Ibrahimli", Age = 31 });
            personList.Add(new Person { Name = "Azad5", Surname = "Ibrahimli55", Age = 31 });
            personList.Add(new Person { Name = "Azad6", Surname = "Ibrahimli", Age = 31 });
            personList.Add(new Person { Name = "Azad7", Surname = "Ibrahimli56", Age = 31 });
            personList.Add(new Person { Name = "Azad8", Surname = "Ibrahimli65", Age = 31 });
            personList.Add(new Person { Name = "Azad9", Surname = "Ibrahimli", Age = 31 });

            Console.WriteLine("enter name:");
            string search = Console.ReadLine();
           

            var input = personList.Find(x => x.Name == search);
            
            {
                if (input == null)
                {
                    Console.WriteLine("not found");

                    return;
                }
                    
                else {

                    Console.WriteLine("found");
                    

                     }
            
            
            
            
            
            }



        }
    }

    }
   


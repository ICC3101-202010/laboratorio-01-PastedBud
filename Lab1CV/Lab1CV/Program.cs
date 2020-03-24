using System;

namespace Lab1CV
{
    class Person
    {
        private string Name;
        private string Lastname;


        public Person(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;
        }

        public int lanzar()
        {   Random rnd = new Random();
            int numero = rnd.Next(0, 3);
            return numero;
        }
            
     }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob", "Kunga");
            Console.WriteLine(p1.lanzar());
         }


    }
}

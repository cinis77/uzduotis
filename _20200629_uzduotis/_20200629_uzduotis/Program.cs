using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_uzduotis
{
    class Program
    {
        interface IHero
        {
            string Name { get; set; }
            string Surname { get; set; }
            string Superpowers { get; set; }
            void Introduce();
        }

        interface IVillain
        {
            string Name { get; set; }
            string Surname { get; set; }
            int Evil { get; set; }
            void Introduce();
        }

        class Hero: IHero
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Superpowers { get; set; }

            public Hero(string name, string surname, string superpowers)
            {
                Name = name;
                Surname = surname;
                Superpowers = superpowers;
            }

            public void Introduce()
            {
                Console.WriteLine("My name is {0} {1} and my superpowers are {2}", Name, Surname, Superpowers);
            }
        }

        class Villain : IVillain
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Evil { get; set; }

            public Villain(string name, string surname, int evil)
            {
                Name = name;
                Surname = surname;
                Evil = evil;
            }

            public void Introduce()
            {
                Console.WriteLine("My name is {0} {1} and my evil levels are {2}", Name, Surname, Evil);
            }
        }

        static void Main(string[] args)
        {
            Hero hero = new Hero("Rolandas", "Paksas", "Flying with Helicopter");
            Villain villain = new Villain("Setonas", "Pragarauskas", 69696969);

            hero.Introduce();
            villain.Introduce();

            Console.ReadLine();
        }
    }
}

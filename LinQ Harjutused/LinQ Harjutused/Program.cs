using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Harjutused
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 40},
                new Human(){Name = "Malle", Age = 42},
                new Human(){Name = "Mari", Age = 30},
                new Human(){Name = "Elmar", Age = 40},
                new Human(){Name = "Juku", Age = 80},
                new Human(){Name = "Janno", Age = 80},
                new Human(){Name = "Kristian", Age = 80},
                new Human(){Name = "Kalmer", Age = 80},
                new Human(){Name = "Eedu", Age = 80},
                new Human(){Name = "Aadu", Age = 80},
                new Human(){Name = "Miisu", Age = 80},
                new Human(){Name = "Siim", Age = 80},
                new Human(){Name = "Simon", Age = 80},
                new Human(){Name = "Andres", Age = 80},
                new Human(){Name = "Tauri", Age = 80},
                new Human(){Name = "Kevin", Age = 80},
                new Human(){Name = "Joonas", Age = 80},
                new Human(){Name = "Rain", Age = 80},
                new Human(){Name = "Elenn", Age = 80},
                new Human(){Name = "May", Age = 80},
                new Human(){Name = "Adeliine", Age = 80},
                new Human(){Name = "Katrin", Age = 80},
                new Human(){Name = "Triinu", Age = 80},
                new Human(){Name = "Kristel", Age = 80},
                new Human(){Name = "Gerrit", Age = 80},
                new Human(){Name = "Getlin", Age = 80},
                new Human(){Name = "Brit", Age = 80},
                new Human(){Name = "Kiisu", Age = 80}
            };

            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var grupid = from human in humans1
            //             group human by human.Age into NewGroup
            //             select NewGroup;

            //foreach (var grupp in grupid)
            //{
            //    Console.WriteLine("Uus Grupp: " + grupp.Key);
            //    foreach (var item in grupp)
            //    {
            //        Console.WriteLine(item.Age + " " + item.Name);
            //    }
            //}

            //var FirstLetterGroup = from human in humans1
            //                       group human by human.Name[0];
            //foreach (var HumanGroup in FirstLetterGroup)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Key: " + HumanGroup.Key);
            //    foreach (var Human in HumanGroup)
            //    {
            //        Console.WriteLine(Human.Name + " " + Human.Age);
            //    }
            //}

            //NIME PIKKUSE JÄRGI
            var grupp1 = from human in humans1
                         group human by human.Name.Length;
            foreach (var uGrupp1 in grupp1)
            {
                Console.WriteLine("Uus Grupp: " + uGrupp1.Key);
                foreach (var item in uGrupp1)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine();
            }
        }
    }
}

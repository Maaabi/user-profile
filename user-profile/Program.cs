using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_profile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте !");

            Console.Write("Напишите как к вам обращаться ? >>");

            string name = Console.ReadLine();

            Console.Write("Сколько вам лет ? >>");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш любимый фильм ? >>");

            string film = (Console.ReadLine());

            Console.Write("Какой ваш знак зодиака ? >>");

            string zodiak = Console.ReadLine();

            Console.WriteLine($"Здравствуйте, {name}");

            Console.WriteLine($"  Вот ваш профиль\n   Возраст : {age}\n   Любимый фильм : {film}\n   Знак зодиака : {zodiak}\n   ");

            Console.WriteLine("Нажмите любую кнопку чтобы выйти...");

            Console.ReadKey();
        }
    }
}

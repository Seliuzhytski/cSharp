using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
   internal class Bear : Animal, ICarnivore, IHerbivore
    {
        private string? sound;
        private string? colour;

        public string TypeC { get => "Хищники";}
        public string FoodC { get => "Лосось"; }

        public void DisplayEatC()
        {
            Console.WriteLine($"Ест: {FoodC}\n");
        }

        public string TypeH { get => "Травоядные"; }
        public string FoodH { get => "Мёд"; }

        public void DisplayEatH()
        {
            Console.WriteLine($"Ест: {FoodH}\n");
        }

        public Bear(string sound, string color)
        {
            this.sound = sound;
            this.colour = color;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Класс: {this.GetType().Name}\n" +
                $"Кличка: {GetName()}\n" +
                $"Количество лап: {GetNumOfLegs()}\n" +
            $"Звук: {sound}\n" +
                $"Окрас: {colour}\n" +
                $"Семейство: {TypeC}, {TypeH}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal class Cat : Animal, ICarnivore
    {
        private string? sound;
        private string? colour;

        public string TypeC { get => "Хищники"; }
        public string FoodC { get => "Мыши"; }
        
        public Cat(string sound, string color)
        {
            this.sound = sound;
            this.colour = color;
        }

        public void DisplayEatC() 
        {
            Console.WriteLine($"Ест: {FoodC}\n");
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Класс: {this.GetType().Name}\n" +
                $"Кличка: {GetName()}\n" +
                $"Количество лап: {GetNumOfLegs()}\n" +
                $"Звук: {sound}\n" +
                $"Окрас: {colour}\n" +
                $"Семейство: {TypeC}");
        }
    }
}

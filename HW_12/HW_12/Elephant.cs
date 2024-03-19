using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HW_12
{
    internal class Elephant : Animal, IHerbivore, IEquatable<Elephant>
    {
        private string? sound;
        private string? colour;
        private int size = 10;

        public string TypeH { get => "Травоядные";}
        public string FoodH { get => "Траву"; }

        public Elephant(string sound, string color)
        {
            this.sound = sound;
            this.colour = color;
        }

        public Elephant(string sound, string color, int size)
        {
            this.sound = sound;
            this.colour = color;
            this.size = size;
        }

        public void DisplayEatH()
        {
            Console.WriteLine($"Ест: {FoodH}\n");
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"Класс: {this.GetType().Name}\n" +
                $"Кличка: {GetName()}\n" +
                $"Количество лап: {GetNumOfLegs()}\n" +
                $"Звук: {sound}\n" +
                $"Окрас: {colour}\n" +
                $"Семейство: {TypeH}");
        }

        public bool Equals(Elephant? other)
        {
            if (other == null)
                return false;

            if(this == other) return true;

            if (this.size > other.size)
                return true;
            else
                return false;
        }

        public static bool operator < (Elephant elephant1, Elephant elephant2)
        {
            if (elephant1.Equals(elephant2))
            {
                return false;
            }

            return elephant1.size < elephant2.size;
        }
        public static bool operator > (Elephant elephant1, Elephant elephant2)
        {
            if (elephant1.Equals(elephant2))
            {
                return false;
            }

            return elephant1.size > elephant2.size;
        }
    }
}

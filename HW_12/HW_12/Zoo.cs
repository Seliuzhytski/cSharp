using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal class Zoo
    {
        internal void Add(Animal animal)
        {
            if (animal == null)
            {
                throw new ArgumentNullException(nameof(animal));
            }
            
            var typeOfCarnivore = typeof(ICarnivore);
            var typeOfHerbivore = typeof(IHerbivore);

             var carnivore = AppDomain.CurrentDomain.GetAssemblies()
                 .SelectMany(s => s.GetTypes())
                 .Where(p => typeOfCarnivore.IsAssignableFrom(p));

             var herbivore = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeOfHerbivore.IsAssignableFrom(p));

            var type = animal.GetType();

            if (carnivore.Contains(type) && herbivore.Contains(type))
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.GetName()} - ест всё, надо строить новый загон");
                return;
            }

            if (carnivore.Contains(type)) 
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.GetName()} - отправляется к хищникам");;
                return;
            }

            if (herbivore.Contains(type))
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.GetName()} - отправляется к травоядным");;
                return;
            }

            throw new Exception("Тип зверя неустановлен");
        }
    }
}

namespace HW_9
{
    internal class Zoo
    {
        private List<Herbivore> herbivore = new List<Herbivore>();
        private List<Predator> predator = new List<Predator>();


        internal void Add(Animal animal)
        {
            if (animal.GetType().BaseType == typeof(Herbivore))
            {
                Console.WriteLine($"{animal.GetType().Name} был отправлен в загон для травоядных");
                herbivore.Add((Herbivore)animal);
                return;
            }
            else if (animal.GetType().BaseType == typeof(Predator))
            {
                Console.WriteLine($"{animal.GetType().Name} был отправлен в загон для хищников");
                predator.Add((Predator)animal);
                return;
            }

            throw new ArgumentException("Зверь неопределён");
        }

        public void ShowHerbivoreAnimal()
        {
            Console.WriteLine("Загон травоядных:");
            foreach (var animal in herbivore)
            {
                Console.WriteLine(animal.GetType().Name);
            }
        }

        public void ShowPredator()
        {
            Console.WriteLine("Загон хищников:");
            foreach (var animal in predator)
            {
                Console.WriteLine(animal.GetType().Name);
            }
        }
    }
}

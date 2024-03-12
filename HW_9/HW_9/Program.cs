using HW_9;

Rabbit rabbit = new Rabbit();
rabbit.Live();

Deer deer = new Deer();
deer.Live();

Wolf wolf = new Wolf();
wolf.Live();

Bear bear = new Bear();
bear.Live();

Zoo GrodnoZoo = new Zoo();
GrodnoZoo.Add(rabbit);
GrodnoZoo.Add(deer);
GrodnoZoo.Add(wolf);
GrodnoZoo.Add(bear);

GrodnoZoo.ShowHerbivoreAnimal();
GrodnoZoo.ShowPredator();
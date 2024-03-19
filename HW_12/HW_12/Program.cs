using HW_12;
using System.Reflection;

var cat = new Cat("Мяу", "Рыжий");
cat.SetName("Барсик");
cat.SetNumberOfLegs(4);
cat.DisplayAnimal();
cat.DisplayEatC();

var elephant = new Elephant("Ууууу", "Серый");
elephant.SetName("Дамбо");
elephant.SetNumberOfLegs(4);
elephant.DisplayAnimal();
elephant.DisplayEatH();

var elephant2 = new Elephant("Тууу", "Синий", 15);

Console.WriteLine(elephant < elephant2);
Console.WriteLine();

var bear = new Bear("Ррр", "Бурый");
bear.SetName("Потапыч");
bear.SetNumberOfLegs(4);
bear.DisplayAnimal();
bear.DisplayEatH();

Zoo zoo = new Zoo();
zoo.Add(cat);
zoo.Add(elephant);
zoo.Add(bear);
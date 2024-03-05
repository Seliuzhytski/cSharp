using System.Threading.Channels;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

//#1
var item = new Item();
item.SetName();
string name = item.GetName();
Console.WriteLine($"Значение приватного поля Name: {name}");

//#2
var Car = new Car();
Car.Move();
var Plane = new Plane();
Plane.Move();

//#3
int[] array = { 1, 2, 3, 576, 7, 1100 };
int maxItem = array.ArrayMaxItem();
Console.WriteLine(maxItem);

//#4
var bag = new Bag();
bag.AddItem(item);
bag.GetItem(0);

//#1
public class Item
{
    private string Name = "unknown";
    
    public void SetName ()
    {
        Console.WriteLine($"Значение по умолчанию: {Name}");
        Console.WriteLine("Введите новое значение Name:");
        string? newName = Console.ReadLine();
        Name = newName;
    }
    public string GetName()
    {
        return Name;
    }
}

//#2
abstract class Transport
{
    
    abstract public Engine Engine { get; set; }
    abstract public void Move();
}

class Engine
{
    static public void Start()
    {
        Console.WriteLine("Заводим двигатель"); 
    }
}

class Car : Transport
{
    public override Engine Engine { get; set; } = new Engine();

    public override void Move()
    {
        Engine.Start();
        Console.WriteLine("Машина поехала");
    }
}

class Plane : Transport
{
    public override Engine Engine { get; set; } = new Engine();

    public override void Move()
    {
        Engine.Start();
        Console.WriteLine("Самолёт полетел");
    }
}



//#3
public static class ArrayExtension
{
    
    public static int ArrayMaxItem (this int[] array)
    {
        int maxValue = array.Max();
        return maxValue;
    }
}

//#4
public class Bag
{
    private Item[] items = new Item[8];
    private bool _isOpen = true;

    public void ChangeIsOpen()
    {
        _isOpen = !_isOpen;
    }

    public void AddItem (Item item)
    {

        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        if (!_isOpen)
        {
            Console.WriteLine("Ничего не происходит");
            return;
        }

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                Console.WriteLine($"Добавили вещь: {item.GetName()}");
                return;
            }
            if (i == items.Length - 1)
            {
                Console.WriteLine("Сумка заполнена");
            }
        }
    }

    public Item GetItem (int index)
    {
        if (index < 0 || index > items.Length)
        {
            throw new ArgumentException(nameof(index));
        }

        if (!_isOpen)
        {
            Console.WriteLine("Ничего не происходит");
            return null;
        }

        
        var item = items[index];
        Console.WriteLine($"Взяли вещь: {item.GetName()}");
        items[index] = null;
        
        return item;
       
    }
}
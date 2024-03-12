namespace HW_9
{
    public abstract class Animal
    {
        virtual public bool isHungry { get; set; }
        virtual public void Live()
        {
            Console.WriteLine("Зверь непонятно чем питается");
        }
    }
}

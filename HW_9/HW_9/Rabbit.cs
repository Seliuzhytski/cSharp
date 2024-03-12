namespace HW_9
{
    public class Rabbit : Herbivore
    {
        override public bool isHungry { get; set; } = true;
        public override void Live()
        {
            if (isHungry)
            {
                EatGrass();
            }
        }
    }
}

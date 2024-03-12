namespace HW_9
{
    public class Deer : Herbivore
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

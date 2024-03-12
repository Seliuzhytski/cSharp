namespace HW_9
{
    public class Wolf : Predator
    {

        override public bool isHungry { get; set; } = true;
        public override void Live()
        {
            if (isHungry)
            {
                Bite();
            }
        }
    }
}

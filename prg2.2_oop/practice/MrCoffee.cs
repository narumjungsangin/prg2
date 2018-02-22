


namespace _0_main
{
    class Program
   {
    public class MrCoffee : CoffeeMaker
    {
        DateTime CoffeeScheduled;
        DateTime CurrentTime;

        public void ScheduleCoffee(DateTime time)
        {
            CoffeeScheduled = time;
        }
        public override void MakeCoffee()
        {
            if(DateTime.Now == CoffeeScheduled)
            {
                base.MakeCoffee();
            }
        }
    }
}
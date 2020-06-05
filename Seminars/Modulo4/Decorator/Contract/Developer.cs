namespace Directos.Module4.Decorator.Contract
{
    public class Developer : Contract
    {
        private int hoursPerWeek;
        private const int HOUR_RATE = 10;

        public Developer(int hoursPerWeek)
        {
            this.hoursPerWeek = hoursPerWeek;
        }

        public override int CalculateBaseSalary() => this.hoursPerWeek * Developer.HOUR_RATE;
    }
}
namespace Directos.Module4.Decorator.Contract
{
    public class Salesman : Contract
    {
        private int hoursPerWeek;
        private int deals;
        private int dealComission;
        private int seniorityPlus;
        private const int HOUR_RATE = 15;

        public Salesman(int hoursPerWeek, int deals, int dealComission, int seniorityPlus)
        {
            this.hoursPerWeek = hoursPerWeek;
            this.deals = deals;
            this.dealComission = dealComission;
            this.seniorityPlus = seniorityPlus;
        }

        public override int CalculateBaseSalary()
        {
            return (this.hoursPerWeek * Salesman.HOUR_RATE) + this.CalculateCommisionPay(this.deals, this.dealComission);
        }

        public override int CalculateCommisionPay(int deals, int dealComission)
        {
            return (this.deals * this.dealComission) + this.seniorityPlus;
        }
    }
}
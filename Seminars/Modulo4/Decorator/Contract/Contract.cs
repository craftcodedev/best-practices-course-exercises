//Cuales son los problemas que vemos aca?
//1. se viola liskov (developer no tiene CalculateCommissionPay) ???
//2. comission se utiliza para calcular el salario, no?? entonces porque no va junto?
//CalculateBaseSalary miren que dice base, que quiere decir esot?? que se aplica para todo y que la comission es un extra. ahi entra el decorator. tenemos algo como base y le añadimos otra funcionabildiad que es calcular la comision
//interface o herencia
namespace Directos.Module4.Decorator.Contract
{
    public abstract class Contract
    {
        public abstract int CalculateBaseSalary();
        
        public virtual int CalculateCommisionPay(int deals, int dealComission)
        {

            return deals * dealComission;
        }
    }
}
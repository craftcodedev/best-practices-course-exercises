namespace Directos.Module3.Ejercicio1
{
    public class PayInvoceUseCase
    {
        private IUserRepository userRespository;

        public PayInvoceUseCase(IUserRepository userRespository)
        {
            this.userRespository = userRespository;
        }
        
        public void Execute(int userId, int invoiceTotal)
        {
            User user = this.userRespository.FindOneById(userId);
            int userBalance = user.getBalance();
            
            if (userBalance < invoiceTotal) {
                throw new System.Exception("not enough funds");
            }

            var newBalance = userBalance - invoiceTotal;
            user.SetBalance(newBalance);
        }
    }
}
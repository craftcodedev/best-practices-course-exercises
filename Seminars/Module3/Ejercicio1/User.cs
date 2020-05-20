namespace Directos.Module3.Ejercicio1
{
    public class User
    {
        private int id;
        private int balance;

        public User(int id, int balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public int Id()
        {
            return this.id;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public int SetBalance(int newBalance)
        {
            return this.balance = newBalance;
        }
    }
}
namespace Directos.Module3.Ejercicio2
{
    public class UserCalculateInsuranceException : System.Exception
    {
        public UserCalculateInsuranceException(string message): base(message){}

        public static UserCalculateInsuranceException FromNationality()
        {
            return new UserCalculateInsuranceException("User is not Spanish");
        }

        public static UserCalculateInsuranceException FromInsurance()
        {
            return new UserCalculateInsuranceException("Insurance not found");
        }
    }
}
namespace App.Infrastructure.Service.Hashing
{
    public interface IHashing
    {
        string Hash(string password);
    }
}
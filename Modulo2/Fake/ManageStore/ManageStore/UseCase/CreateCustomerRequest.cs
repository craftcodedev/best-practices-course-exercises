namespace ManageStore.UseCase
{
    public class CreateCustomerRequest
    {
        public CreateCustomerRequest(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        
        public int Id { get; }
        public string Name { get; }
    }
}

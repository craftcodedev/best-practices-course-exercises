namespace ManageStore.UseCase
{
    public class CreateCustomerRequest
    {
        public string id;
        public string name;

        public CreateCustomerRequest(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
namespace ManageStore.Model.Customer
{
    public class FindCustomerByIdRequest
    {
        public FindCustomerByIdRequest(int id)
        {
            this.Id = id;
        }
        
        public int Id { get; }
    }
}

using ManageStore.Service.Logs;

namespace ManageStore.Model.Customer
{
    public class CustomerDTO
    {
        public CustomerDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

namespace App.Model.User
{
    public class UserDTO : ILoggable
    {
        public UserDTO(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Services
{
    public class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            //using (var cn = new SqlConnection())
            //{
            //    var cmd = new SqlCommand();

            //    cn.ConnectionString = "ConnectionString";
            //    cmd.Connection = cn;
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "INSERT INTO USER (NAME, EMAIL CPF, BIRTHDATE) VALUES (@name, @email, @cpf, @birthdate))";

            //    cmd.Parameters.AddWithValue("name", Name);
            //    cmd.Parameters.AddWithValue("email", Email);
            //    cmd.Parameters.AddWithValue("nif", NIF);
            //    cmd.Parameters.AddWithValue("birthdate", BirthDate);

            //    cn.Open();
            //    cmd.ExecuteNonQuery();
            //}
        }
    }
}

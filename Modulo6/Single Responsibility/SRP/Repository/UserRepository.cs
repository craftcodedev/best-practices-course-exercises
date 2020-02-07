﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Repository
{
    public class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USER (NAME, EMAIL CPF, BIRTHDATE) VALUES (@name, @email, @cpf, @birthdate))";

                cmd.Parameters.AddWithValue("email", user.EmailInfoUser());
                cmd.Parameters.AddWithValue("nif", user.NIFInfoUser());

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
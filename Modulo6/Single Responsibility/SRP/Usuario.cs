using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SRP 
{
    public class User2
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string NIF { get; set; }
        public DateTime BirthDate { get; set; }

        public string AddUser()
        {
            if (!Email.Contains("@"))
                return "Invalid user";

            if (NIF.Length != 11)
                return "User with invalid NIF";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USER (NAME, EMAIL CPF, BIRTHDATE) VALUES (@name, @email, @cpf, @birthdate))";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("nif", NIF);
                cmd.Parameters.AddWithValue("birthdate", BirthDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("solid@dh.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome";
            mail.Body = "Course SOLID";
            client.Send(mail);

            return "User added correctly!";
        }
    }
}
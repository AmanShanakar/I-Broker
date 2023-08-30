using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BrokerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UserLoginService : IUserLoginService
    {
        public UserLogin GetUser(string Name, string Password)
        {
            UserLogin user = new UserLogin();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterName = new SqlParameter();
                parameterName.ParameterName = "@Name";
                parameterName.Value = Name;
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterPassword = new SqlParameter();
                parameterPassword.ParameterName = "@Password";
                parameterPassword.Value = Name;
                cmd.Parameters.Add(parameterPassword);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.Name = reader["Name"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Status = reader["Status"].ToString();
                }
            }
            return user;
        }
    }
}

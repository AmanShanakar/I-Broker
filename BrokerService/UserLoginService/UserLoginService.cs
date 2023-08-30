using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UserLoginService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserLoginService" in both code and config file together.
    public class UserLoginService : IUserLoginService
    {
        public int GetUser(string Name, string Password, string Status) //, string Status
        {
            int returnValue = -1; // Default value indicating an error
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@Name", Name);
                SqlParameter paramPassword = new SqlParameter("@Password", Password);
                SqlParameter paramStatus = new SqlParameter("@Status", Status);

                SqlParameter paramReturnValue = new SqlParameter("@ReturnValue", SqlDbType.Int);
                paramReturnValue.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramReturnValue);
                cmd.Parameters.Add(paramStatus);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                returnValue = Convert.ToInt32(paramReturnValue.Value);
            }
            return returnValue;
        }
    }
}



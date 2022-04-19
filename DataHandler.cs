using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;


namespace DAL
{
    public class DataHandler : IDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DataHandler()
        {
            connection.DataSource = @"LAPTOP-FEJDHTB5\SQLEXPRESS";
            connection.InitialCatalog = "dbUserManagement";
            connection.IntegratedSecurity = true;
        }

        public bool UpdateUserPassword(ArrayList input)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(connection.ToString());
            using (conn)
            {


                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("sp_UpdatePassword", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.AddWithValue("@idnum", input[0]);
                        cmd.Parameters.AddWithValue("@username", input[1]);
                        cmd.Parameters.AddWithValue("@passwordEntered", input[2]);
                        result = cmd.ExecuteNonQuery();
                    }


                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                finally
                { conn.Close(); }


            }


            return (result > 0);
        }

        public DataSet ReadData(string tableName)
        {
            DataSet rawData = new DataSet();
            SqlConnection conn = new SqlConnection(connection.ToString());
            using (conn)
            {
                string qry = @"SELECT tblUsers.*, tblPerson.* FROM  tblUsers INNER JOIN
                         tblPerson ON tblUsers.IdNum = tblPerson.NationalIDNumber";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                    adapter.FillSchema(rawData, SchemaType.Source, tableName);
                    adapter.Fill(rawData, tableName);
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                finally
                { conn.Close(); }

            }
            return rawData;
        }

        public bool InsertNewUser(ArrayList input)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(connection.ToString());
            using (conn)
            {
               

                try
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(@"insert into tblPerson
(First_Name, Surname, NationalIDNumber)
values
(@fName, @lName, @IdNumber)

insert into tblUsers
(IdNum,Username,Password)
values
(@IdNumber, @username, @password)
	", conn))
                    {
                        cmd.Parameters.AddWithValue("@fname", input[1]);
                        cmd.Parameters.AddWithValue("@lName", input[2]);
                        cmd.Parameters.AddWithValue("@IdNumber", input[0]);
                        cmd.Parameters.AddWithValue("@username", input[3]);
                        cmd.Parameters.AddWithValue("@password", input[4]);
                        result = cmd.ExecuteNonQuery();

                    }
                   

                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                finally
                { conn.Close(); }


            }


            return (result>0);
        }
    }
}

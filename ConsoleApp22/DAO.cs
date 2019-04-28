using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class DAO
    {
        public void Insert(List<int> list, string table)
        {
                 using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Passover;Integrated Security=True"))
                 {

                foreach (int number in list)
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO {table} VALUES {number}", conn);

                    cmd.Connection.Open();
                    cmd.CommandType = CommandType.Text;

                    cmd.ExecuteNonQuery();

                    cmd.Connection.Close(); 
                }
            }
        }
    }
}

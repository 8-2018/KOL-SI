using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MenuItemRepository
    {
        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> results = new List<MenuItem>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM MenuItems";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    MenuItem mi = new MenuItem();
                    mi.Id = sqlDataReader.GetInt32(0);
                    mi.Title = sqlDataReader.GetString(1);
                    mi.Description = sqlDataReader.GetString(2);
                    mi.Price = sqlDataReader.GetDecimal(3);

                    results.Add(mi);
                }
            }

            return results;
        }

        public int InsertMenuItem(MenuItem mi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO MenuItems VALUES ('{0}', '{1}', {2})",
                        mi.Title, mi.Description, mi.Price);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

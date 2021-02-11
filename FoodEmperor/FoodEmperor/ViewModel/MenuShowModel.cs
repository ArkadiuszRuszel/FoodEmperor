using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FoodEmperor.ViewModel
{

        public class MenuShowModel
        {
            public MenuShowModel()
            {
                DataTableCollection = GetDataTable();
            }
            public DataTable DataTableCollection { get; set; }

            private DataTable GetDataTable()
            {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(decimal));
            dataTable.Columns.Add("Nazwa pizzy", typeof(string));
            dataTable.Columns.Add("Cena małej", typeof(string));
            dataTable.Columns.Add("Cena średniej", typeof(string));
            dataTable.Columns.Add("Cena dużej", typeof(string));


            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "foodemperor.database.windows.net";
                builder.UserID = "Emperor";
                builder.Password = "Foodfood1";
                builder.InitialCatalog = "FoodEmperor";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    //StringBuilder sb = new StringBuilder();
                    //sb.Append("SELECT MAX(Id) ");
                    //sb.Append("FROM Menu ");
                    //String sql = sb.ToString();
                    string text = ("SELECT * FROM Menu");

                    using (SqlCommand command = new SqlCommand(text, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataTable.Rows.Add( reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                              
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
               // DisplayAlert("Powiadomienie", "nie można pobrać danych", "OK");
            }

            return dataTable;
            }
        }
}

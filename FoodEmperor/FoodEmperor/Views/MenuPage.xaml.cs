using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodEmperor.Model;
using System.Data.SqlClient;
using System.Data;

namespace FoodEmperor.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private async void Go_to_Menu_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        private async void Go_to_MenuShow_page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuShowPage());
        }

        //private async void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new LandingPage());
        //}



        private void Button_Clicked_Create(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "foodemperor.database.windows.net";
                builder.UserID = "Emperor";
                builder.Password = "Foodfood1";
                builder.InitialCatalog = "FoodEmperor";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                  
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Menu values ");
                    sb.Append("('"+ID.Text+"','"+Nazwa.Text+"','"+CenaS.Text+"','"+CenaM.Text+"','"+CenaL.Text+"')");
                    String sql = sb.ToString();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    DisplayAlert("Powiadomienie", "Pomyślnie wykonałeś operacje", "OK");

                }
            }
            catch (SqlException)
            {
                DisplayAlert("Powiadomienie", "wprowadziłeś złe dane","OK");
            }
        }

        private void Button_Clicked_Update(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "foodemperor.database.windows.net";
                builder.UserID = "Emperor";
                builder.Password = "Foodfood1";
                builder.InitialCatalog = "FoodEmperor";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE Menu SET ");
                    sb.Append("Nazwa='"+Nazwa.Text +"',CenaS='"+CenaS.Text+"',CenaM='"+CenaM.Text+"',CenaL='" + CenaL.Text + "' ");
                    sb.Append("WHERE Id="+ID.Text);
                    String sql = sb.ToString();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    DisplayAlert("Powiadomienie", "Pomyślnie wykonałeś operacje", "OK");
                }
            }
            catch (SqlException)
            {
                DisplayAlert("Powiadomienie", "wprowadziłeś złe dane", "OK");
            }
        }

        private void Button_Clicked_Delete(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "foodemperor.database.windows.net";
                builder.UserID = "Emperor";
                builder.Password = "Foodfood1";
                builder.InitialCatalog = "FoodEmperor";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM Menu ");
                    sb.Append("WHERE Id=" + ID.Text);
                    String sql = sb.ToString();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    DisplayAlert("Powiadomienie", "Pomyślnie wykonałeś operacje", "OK");

                }
            }
            catch (SqlException)
            {
                DisplayAlert("Powiadomienie", "wprowadziłeś złe dane", "OK");
            }
        }
    }
}
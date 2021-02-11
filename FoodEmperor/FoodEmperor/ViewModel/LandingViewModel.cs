using System;
using FoodEmperor.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using FoodEmperor.Views;

namespace FoodEmperor.ViewModel
{
    class LandingViewModel : BaseViewModel
    {
        public LandingViewModel()
        {
            pizzas = GetPizzas();
        }


        public ObservableCollection<pizza> pizzas { get; set; }

        public ObservableCollection<pizza> Pizzas
        {
            get { return pizzas; }
            set
            {
                pizzas = value;
                OnPropertyChanged();
            }
        }

        private pizza selectedPizza;

        public pizza SelectedPizza
        {
            get { return selectedPizza; }
            set
            {
                selectedPizza = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectionCommand => new Command(DisplayPizza);

        private void DisplayPizza()
        {
            if (selectedPizza != null)
            {
                var viewModel = new DetailsViewModel { SelectedPizza = selectedPizza, Pizzas = pizzas, Position = pizzas.IndexOf(selectedPizza) };
                var detailsPage = new DetailsPage { BindingContext = viewModel };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(detailsPage, true);
            }
        }

        private ObservableCollection<pizza> GetPizzas()
        {
            return new ObservableCollection<pizza>
            {
                new pizza{ 
                    Name = "PEPPERONI", 
                    Price = 24, 
                    Image = "pepperoniblack.JPG", 
                    Description = "Pizza pepperoni to jedna z najpopularniejszych pozycji w menu każdej pizzerii. Jej podstawowa wersja jest bardzo prosta i zawiera oprócz sosu pomidorowego ser, i plasterki popularnego pepperoni, od którego ten wariant pizzy czerpie swoją nazwę.",
                    Ingredients = "Składniki: kiełbasa pepperoni, papryka pepperoni, sos pomidorowy, ser mozzarella"},
                new pizza { 
                    Name = "PROSCIUTTO", 
                    Price = 30, 
                    Image = "prosciuttoblack.JPG", 
                    Description = "Pizza z szynką parmeńską i rukolą łączy w sobie niezwykły smak pizzy oraz jednej z najdelikatniejszych i najlepszych włoskich wędlin – prosciutto crudo di Parma.",
                    Ingredients = "Składniki: szynka parmeńska, rukola, pomidor koktajlowy, sos pomidorowy, ser mozzarella, ser parmezan"},
                new pizza { 
                    Name = "BEEF", 
                    Price = 34, 
                    Image = "beefblack.jpg", 
                    Description = "Pizza ze znakomitą wołowiną. Smakuje nieziemsko.",
                    Ingredients = "Składniki: wołowina, cebula, sos pomidorowy, ser mozzarella"},
                new pizza { 
                    Name = "VEGE", 
                    Price = 23, 
                    Image = "vegeblack.jpg", 
                    Description = "Wiele osób sądzi, że tylko mięso czy wędliny nadadzą pizzy odpowiedni smak. Nic bardziej mylnego.",
                    Ingredients = "Składniki: pomidor, papryka, świeża bazylia, sos pomidorowy, ser mozzarella"},

            };
        }
        
    }
}

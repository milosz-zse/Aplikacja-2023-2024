using System.Collections.ObjectModel;

namespace ShowCollectionMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> FruitsCollectons { get; set;  }

        public string SelcetedFruit { get; set; }

        private string selectedFruitMessage;

        public string SelectedFruitMessage
        {
            get { return selectedFruitMessage; }
            set { selectedFruitMessage = value; OnPropertyChanged(); }
        }
        public string NewFruitName { get; set; }




        public MainPage()
        {
            FruitsCollectons = new ObservableCollection<string>();
            FruitsCollectons.Add("BANNANAN NAN");
            FruitsCollectons.Add("APPLES");
            FruitsCollectons.Add("orange");
            FruitsCollectons.Add("dead kennedys");
            FruitsCollectons.Add("dezerterr");

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SelectedFruitMessage = "wybrany owoc" + SelcetedFruit ;
        }

        private void Button_New_Fruit(object sender, EventArgs e)
        {
            FruitsCollectons.Add(NewFruitName);
           
        }
    }

}

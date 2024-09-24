namespace ShowCollectionMauiApp
{
    public partial class MainPage : ContentPage
    {
        public List<string> FruitsCollectons { get; set; }

        public string SelcetedFruit { get; set; }

        private string selectedFruitMessage;

        public string SelectedFruitMessage
        {
            get { return selectedFruitMessage; }
            set { selectedFruitMessage = value; OnPropertyChanged(); }
        }




        public MainPage()
        {
            FruitsCollectons = new List<string>();
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
    }

}

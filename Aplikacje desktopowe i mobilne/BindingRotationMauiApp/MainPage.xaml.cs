namespace BindingRotationMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Massage { get; set; }
        private string processedNumber;

        public string ProcessedNumber
        {
            get { return processedNumber; }
            set {
                processedNumber = value;
                OnPropertyChanged();
                }
        }
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void LabelSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            messageLabel.Text = $"Poziom skuwaka {LabelSlider.Value}";            
            RotateLabel.RotateTo(LabelSlider.Value);
           
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string message = Massage;
            int numberOfCharacters = message.Length;
            processedNumber = $"ilosśc {numberOfCharacters}";

        }
    }

}

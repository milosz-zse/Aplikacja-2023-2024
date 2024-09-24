namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            Label1.FontSize = count;
            if (count%2!=0)
            {
                await Icon.RotateTo(1440, 9000);
            }
            
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

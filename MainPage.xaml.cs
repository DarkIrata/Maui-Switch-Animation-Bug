namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private AnotherPage ap;

        public MainPage()
        {
            InitializeComponent();
            ap = new AnotherPage(this, "Bugged");
        }

        private void NavigateBtnBugged_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(ap);
        }

        private void NavigateBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new AnotherPage(this, "Working"));
        }
    }
}
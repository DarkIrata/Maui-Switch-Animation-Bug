namespace MauiApp2;

public partial class AnotherPage : ContentPage
{
    private MainPage mp;

    public AnotherPage(MainPage mainPage, string title)
    {
        this.mp = mainPage;
        InitializeComponent();
        this.Title = title;
    }

    private void NavigateBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(mp);
    }
}
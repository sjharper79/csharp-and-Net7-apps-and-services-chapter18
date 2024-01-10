namespace Northwind.Maui.Client;

public partial class EmployeesPage : ContentPage
{
    public EmployeesPage()
    {
        InitializeComponent();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        Output.Text = "0.0";
        foreach (Button button in gridCalculator.Children.OfType<Button>())
        {
            button.FontSize = 24;
            button.WidthRequest = 54;
            button.HeightRequest = 54;
            button.Clicked += Button_Clicked;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        string operationChars = "+-/X=";
        Button button = (Button)sender;
        if (operationChars.Contains(button.Text))
        {
            Output.Text = string.Empty;
        }
        else
        {
            Output.Text += button.Text;
        }
    }
}
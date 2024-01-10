namespace Northwind.Maui.Client;

public partial class CustomerDetailPage : ContentPage
{
    private CustomersListViewModel customers;
    public CustomerDetailPage(CustomersListViewModel customers)
    {
        InitializeComponent();
        this.customers = customers;
        BindingContext = new CustomerDetailViewModel();
        Title = "Add Customer";
    }
    public CustomerDetailPage(CustomersListViewModel customers, CustomerDetailViewModel customer)
    {
        InitializeComponent();
        this.customers = customers;
        BindingContext = customer;
        InsertButton.IsVisible = false;
    }
    async void InsertButton_Clicked(object sender, EventArgs e)
    {
        customers.Add((CustomerDetailViewModel)BindingContext);
        await Navigation.PopAsync(true);
    }
}
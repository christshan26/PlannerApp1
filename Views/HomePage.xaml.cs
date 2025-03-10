using PlannerApp1.ViewModels;

namespace PlannerApp1.Views;

public partial class HomePage : ContentPage
{
    // Constructor for HomePage
    public HomePage()
    {
        InitializeComponent(); // Initialize the components defined in XAML
        BindingContext = new HomeViewModel(); // Set the BindingContext to a new instance of HomeViewModel
    }
}
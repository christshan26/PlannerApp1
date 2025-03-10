using PlannerApp1.ViewModels;

namespace PlannerApp1.Views;

public partial class NewActivityPage : ContentPage
{
    // Constructor for NewActivityPage
    public NewActivityPage()
    {
        InitializeComponent(); // Initialize the components defined in XAML
        BindingContext = new NewActivityViewModel(); // Set the BindingContext to a new instance of NewActivityViewModel
    }
}
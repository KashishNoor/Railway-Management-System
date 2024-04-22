using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class PassengerPage : Page
{
    public PassengerViewModel ViewModel
    {
        get;
    }

    public PassengerPage()
    {
        ViewModel = App.GetService<PassengerViewModel>();
        InitializeComponent();
    }
}

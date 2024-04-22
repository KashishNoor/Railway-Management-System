using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class AdminPage : Page
{
    public AdminViewModel ViewModel
    {
        get;
    }

    public AdminPage()
    {
        ViewModel = App.GetService<AdminViewModel>();
        InitializeComponent();
    }
}

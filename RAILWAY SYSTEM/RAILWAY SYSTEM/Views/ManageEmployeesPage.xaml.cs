using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class ManageEmployeesPage : Page
{
    public ManageEmployeesViewModel ViewModel
    {
        get;
    }

    public ManageEmployeesPage()
    {
        ViewModel = App.GetService<ManageEmployeesViewModel>();
        InitializeComponent();
    }
}

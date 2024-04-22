using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class EmployeesPage : Page
{
    public EmployeesViewModel ViewModel
    {
        get;
    }

    public EmployeesPage()
    {
        ViewModel = App.GetService<EmployeesViewModel>();
        InitializeComponent();
    }
}

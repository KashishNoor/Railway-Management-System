using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class Delete_EmployeePage : Page
{
    public Delete_EmployeeViewModel ViewModel
    {
        get;
    }

    public Delete_EmployeePage()
    {
        ViewModel = App.GetService<Delete_EmployeeViewModel>();
        InitializeComponent();
    }
}

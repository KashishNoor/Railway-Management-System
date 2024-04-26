using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class Update_EmployeePage : Page
{
    public Update_EmployeeViewModel ViewModel
    {
        get;
    }

    public Update_EmployeePage()
    {
        ViewModel = App.GetService<Update_EmployeeViewModel>();
        InitializeComponent();
    }
}

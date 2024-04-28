using Microsoft.UI.Xaml;
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

    private void Up1_Click(object sender, RoutedEventArgs e)
    {
    }
}

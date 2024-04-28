using Microsoft.UI.Xaml;
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

    private void Add1_Click(object sender, RoutedEventArgs e)
    {
    }

    private void Del1_Click(object sender, RoutedEventArgs e)
    {
    }

    private void Up1_Click(object sender, RoutedEventArgs e)
    {
    }
}

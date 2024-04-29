using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class Task_AssesmentPage : Page
{
    public Task_AssesmentViewModel ViewModel
    {
        get;
    }

    public Task_AssesmentPage()
    {
        ViewModel = App.GetService<Task_AssesmentViewModel>();
        InitializeComponent();
    }

    private void Assign_Click(object sender, RoutedEventArgs e)
    {
    }
}

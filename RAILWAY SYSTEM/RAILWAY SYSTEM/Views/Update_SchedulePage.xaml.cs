using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class Update_SchedulePage : Page
{
    public Update_ScheduleViewModel ViewModel
    {
        get;
    }

    public Update_SchedulePage()
    {
        ViewModel = App.GetService<Update_ScheduleViewModel>();
        InitializeComponent();
    }

    private void Ups_Click(object sender, RoutedEventArgs e)
    {
    }
}

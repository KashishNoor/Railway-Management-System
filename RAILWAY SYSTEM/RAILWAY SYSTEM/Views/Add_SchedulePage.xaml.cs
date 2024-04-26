using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class Add_SchedulePage : Page
{
    public Add_ScheduleViewModel ViewModel
    {
        get;
    }

    public Add_SchedulePage()
    {
        ViewModel = App.GetService<Add_ScheduleViewModel>();
        InitializeComponent();
    }
}

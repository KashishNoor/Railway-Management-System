using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class Delete_SchedulePage : Page
{
    public Delete_ScheduleViewModel ViewModel
    {
        get;
    }

    public Delete_SchedulePage()
    {
        ViewModel = App.GetService<Delete_ScheduleViewModel>();
        InitializeComponent();
    }
}

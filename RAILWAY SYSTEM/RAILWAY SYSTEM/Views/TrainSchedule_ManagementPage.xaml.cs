using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class TrainSchedule_ManagementPage : Page
{
    public TrainSchedule_ManagementViewModel ViewModel
    {
        get;
    }

    public TrainSchedule_ManagementPage()
    {
        ViewModel = App.GetService<TrainSchedule_ManagementViewModel>();
        InitializeComponent();
    }
}

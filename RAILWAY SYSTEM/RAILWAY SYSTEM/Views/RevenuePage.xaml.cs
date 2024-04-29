using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class RevenuePage : Page
{
    public RevenueViewModel ViewModel
    {
        get;
    }

    public RevenuePage()
    {
        ViewModel = App.GetService<RevenueViewModel>();
        InitializeComponent();
    }
}

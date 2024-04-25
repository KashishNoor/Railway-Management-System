using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class ViewTrainsPage : Page
{
    public ViewTrainsViewModel ViewModel
    {
        get;
    }

    public ViewTrainsPage()
    {
        ViewModel = App.GetService<ViewTrainsViewModel>();
        InitializeComponent();
    }
}

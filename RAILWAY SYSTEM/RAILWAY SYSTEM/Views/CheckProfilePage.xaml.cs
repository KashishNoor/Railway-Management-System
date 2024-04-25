using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class CheckProfilePage : Page
{
    public CheckProfileViewModel ViewModel
    {
        get;
    }

    public CheckProfilePage()
    {
        ViewModel = App.GetService<CheckProfileViewModel>();
        InitializeComponent();
    }
}

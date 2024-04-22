using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class SignupPage : Page
{
    public SignupViewModel ViewModel
    {
        get;
    }

    public SignupPage()
    {
        ViewModel = App.GetService<SignupViewModel>();
        InitializeComponent();
    }
}

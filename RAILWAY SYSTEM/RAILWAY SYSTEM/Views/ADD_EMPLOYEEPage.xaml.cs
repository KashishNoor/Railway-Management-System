using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class ADD_EMPLOYEEPage : Page
{
    public ADD_EMPLOYEEViewModel ViewModel
    {
        get;
    }

    public ADD_EMPLOYEEPage()
    {
        ViewModel = App.GetService<ADD_EMPLOYEEViewModel>();
        InitializeComponent();
    }
}

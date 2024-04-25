using Microsoft.UI.Xaml.Controls;

using RAILWAY_SYSTEM.ViewModels;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class ViewFeedbackPage : Page
{
    public ViewFeedbackViewModel ViewModel
    {
        get;
    }

    public ViewFeedbackPage()
    {
        ViewModel = App.GetService<ViewFeedbackViewModel>();
        InitializeComponent();
    }
}

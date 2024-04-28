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

    private void Control2_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
        // Event handler for text change
    }

    private void Control2_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
    {
        // Event handler for query submission
    }

    private void Control2_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
    {
        // Event handler for suggestion chosen
    }
}

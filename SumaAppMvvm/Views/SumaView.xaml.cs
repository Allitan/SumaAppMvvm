using SumaAppMvvm.ViewModels;

namespace SumaAppMvvm.Views;

public partial class SumaView : ContentPage
{
    SumaViewModel viewModel;
    public SumaView()
	{
		InitializeComponent();
        viewModel = new SumaViewModel();
        BindingContext = viewModel;
    }
}
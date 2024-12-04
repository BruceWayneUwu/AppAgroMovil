using AppAgroMovil.MVVM.ViewModels;

namespace AppAgroMovil.MVVM.View.Data;

public partial class DataAnalysis : ContentPage
{

    private readonly ProductsViewModel _viewModel;

    public DataAnalysis(ProductsViewModel viewModel)
	{
        InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadProductsAsync();
    }
}
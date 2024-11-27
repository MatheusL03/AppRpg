namespace AppRpgEtec.Views.Disputas;
using AppRpgEtec.ViewModels.Disputas;

public partial class ListagemView : ContentPage
{
	DisputaViewModel viewModel;

	public ListagemView()
	{
		InitializeComponent();

		viewModel = new DisputaViewModel();
		BindingContext = viewModel;
	}
}
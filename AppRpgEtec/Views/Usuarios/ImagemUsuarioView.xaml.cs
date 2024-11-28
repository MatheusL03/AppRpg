namespace AppRpgEtec.Views.Usuarios;

public partial class ImagemUsuarioView : ContentPage
{
	ImagemUsuarioView viewModel;
	public ImagemUsuarioView()
	{
		InitializeComponent();

		viewModel = new ImagemUsuarioView();
		Title = "Imagem do Usuário";
		BindingContext = viewModel;
	}
}
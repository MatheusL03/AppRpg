using Azure.Storage.Blobs;
using Microsoft.Maui.Storage;
using System.ComponentModel;
using AppRpgEtec.Views.Usuarios;

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
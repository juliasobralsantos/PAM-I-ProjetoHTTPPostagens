using ProjetoExemploHTTP.ViewModels;

namespace ProjetoExemploHTTP.Views;

public partial class PostagensView : ContentPage
{
	public PostagensView()
	{
		BindingContext = new ProjetoExemploHTTPViewModel();
		InitializeComponent();
	}
}
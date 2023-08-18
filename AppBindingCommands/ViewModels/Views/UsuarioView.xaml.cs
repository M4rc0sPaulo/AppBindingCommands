namespace AppBindingCommands.ViewModels.Views;

public partial class UsuarioView : ContentPage
{
	public UsuarioView()
	{
        InitializeComponent();
        BindingContext = new UsuarioViewModel();

    }
}
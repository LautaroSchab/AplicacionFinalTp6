namespace AplicacionTp6.Views;

public partial class UsuarioCrearPage : ContentPage
{
	public UsuarioCrearPage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PopAsync();
    }
}
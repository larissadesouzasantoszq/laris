using Microsoft.Maui.Controls;

namespace LoginConfirmado
{
    public partial class LoginConfirmado : ContentPage
    {
        public LoginConfirmado()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Implementar a lógica de autenticação aqui
            if (username == "admin" && password == "password")
            {
                // Navegar para a página de confirmação de login
                await Navigation.PushAsync(new ConfirmationPage());
            }
            else
            {
                await DisplayAlert("Login", "Nome de usuário ou senha incorretos.", "Tentar novamente");
            }
        }
    }
}

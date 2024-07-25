using Microsoft.Maui.Controls;

namespace CadastroCliente
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
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
                await DisplayAlert("Login", "Login bem-sucedido!", "OK");
            }
            else
            {
                await DisplayAlert("Login", "Nome de usuário ou senha incorretos.", "Tentar novamente");
            }
        }
    }
}

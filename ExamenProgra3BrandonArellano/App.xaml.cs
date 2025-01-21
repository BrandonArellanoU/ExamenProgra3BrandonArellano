using ExamenProgra3BrandonArellano.Repository;
using Microsoft.Maui.Controls;

namespace ExamenProgra3BrandonArellano
{
    public partial class App : Application
    {
        public App()
        {
            // Inicializa los componentes de la aplicación.
            InitializeComponent();

            // Configura la página principal.
            MainPage = new MainPage();
        }
    }
}

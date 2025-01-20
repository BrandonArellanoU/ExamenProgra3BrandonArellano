using ExamenProgra3BrandonArellano.Repository;
using ExamenProgra3BrandonArellano.Models;

namespace ExamenProgra3BrandonArellano.Views
{
    public partial class BuscarPage : ContentPage
    {
        private readonly BrandonApi _api;
        private readonly BrandonSqlite _baseDatos;

        public BuscarPage()
        {
            InitializeComponent();
            _api = new BrandonApi();
            _baseDatos = App.Database;
        }

        private async void OnBuscarClicked(object sender, EventArgs e)
        {
            string nombrePais = BuscarEntry.Text;

            if (string.IsNullOrWhiteSpace(nombrePais))
            {
                await DisplayAlert("Error", "Por favor, ingrese un nombre v�lido.", "OK");
                return;
            }

            try
            {
                // Consultar el pa�s desde la API
                var pais = await _api.TenerNombre(nombrePais);

                if (pais != null)
                {
                    ResultadoLabel.Text = $"Nombre Oficial: {pais.name.official}\n" +
                                          $"Regi�n: {pais.region}\n" +
                                          $"Mapa: {pais.maps.googleMaps}";

                    // Guardar en la base de datos
                    await _baseDatos.Guardar(pais);

                    await DisplayAlert("�xito", "El pa�s ha sido guardado correctamente.", "OK");
                }
                else
                {
                    await DisplayAlert("Error", "No se encontr� el pa�s.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurri� un error: {ex.Message}", "OK");
            }
        }

        private void OnLimpiarClicked(object sender, EventArgs e)
        {
            BuscarEntry.Text = string.Empty;
            ResultadoLabel.Text = string.Empty;
        }
    }
}

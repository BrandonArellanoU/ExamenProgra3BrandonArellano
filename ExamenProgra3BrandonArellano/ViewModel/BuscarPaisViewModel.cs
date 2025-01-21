using ExamenProgra3BrandonArellano.Models;
using ExamenProgra3BrandonArellano.Repository;
using System.Windows.Input;

namespace ExamenProgra3BrandonArellano.ViewModel
{
    public class BuscarPaisViewModel : BindableObject
    {
        public BuscarPaisViewModel()
        {
            _apiRepo = new PaisApiRepository();
            _bdRepo = new PaisBDRepository("brandonAre_bd.db");
        }

        private string _nombrePais;
        private string _resultado;
        private readonly PaisApiRepository _apiRepo;
        private readonly PaisBDRepository _bdRepo;

        public string NombrePais
        {
            get => _nombrePais;
            set { _nombrePais = value; OnPropertyChanged(); }
        }

        public string Resultado
        {
            get => _resultado;
            set { _resultado = value; OnPropertyChanged(); }
        }

        public ICommand BuscarCommand => new Command(async () => await BuscarPaisAsync());
        public ICommand LimpiarCommand => new Command(() => NombrePais = string.Empty);

        private async Task BuscarPaisAsync()
        {
            try
            {
                var pais = await _apiRepo.ObtenerPais(NombrePais);
                if (pais != null)
                {
                    Resultado = $"País encontrado: {pais.name.official}";
                    _bdRepo.GuardarPais(new ModeloBBDD
                    {
                        NombreOficial = pais.name.official,
                        Region = pais.region,
                        LinkGoogleMaps = pais.maps.googleMaps,
                        Usuario = "Scordova"
                    });
                }
                else
                {
                    Resultado = "País no encontrado.";
                }
            }
            catch (Exception ex)
            {
                Resultado = $"Error: {ex.Message}";
            }
        }

    }
}
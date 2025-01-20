using ExamenProgra3BrandonArellano.Models;
using ExamenProgra3BrandonArellano.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3BrandonArellano.ViewModel
{
    public class BuscarPaisViewModel : BindableObject
    {
        private string _nombrePais;
        private string _resultado;
        private readonly PaisApiRepository _apiRepositorio;
        private readonly PaisBDRepository _bdRepositorio;

        public string NombrePais
        {
            get => _nombrePais;
            set
            {
                _nombrePais = value;
                OnPropertyChanged();
            }
        }

        public string Resultado
        {
            get => _resultado;
            set
            {
                _resultado = value;
                OnPropertyChanged();
            }
        }

        public Command BuscarCommand { get; }
        public Command LimpiarCommand { get; }

        public BuscarPaisViewModel(PaisApiRepository apiRepositorio, PaisBDRepository bdRepositorio)
        {
            _apiRepositorio = apiRepositorio;
            _bdRepositorio = bdRepositorio;

            BuscarCommand = new Command(async () => await BuscarPais());
            LimpiarCommand = new Command(() => NombrePais = string.Empty);
        }

        private async Task BuscarPais()
        {
            if (string.IsNullOrWhiteSpace(NombrePais))
            {
                Resultado = "Por favor, ingresa un nombre válido.";
                return;
            }

            try
            {
                var paisAPI = await _apiRepositorio.ObtenerPais(NombrePais);
                if (paisAPI != null)
                {
                    var pais = new ModeloBBDD
                    {
                        NombreOficial = paisAPI.name.official,
                        Region = paisAPI.region,
                        LinkGoogleMaps = paisAPI.maps.googleMaps,
                        Usuario = "UsuarioEjemplo"
                    };

                    _bdRepositorio.GuardarPais(pais);

                    Resultado = $"País encontrado:\nNombre: {pais.NombreOficial}, Región: {pais.Region}, Mapa: {pais.LinkGoogleMaps}";
                }
                else
                {
                    Resultado = "No se encontró ningún país con ese nombre.";
                }
            }
            catch (Exception ex)
            {
                Resultado = $"Error: {ex.Message}";
            }
        }
    }
}

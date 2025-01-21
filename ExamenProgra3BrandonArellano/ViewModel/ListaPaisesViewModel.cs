using ExamenProgra3BrandonArellano.Models;
using ExamenProgra3BrandonArellano.Repository;
using System.Collections.ObjectModel;

namespace ExamenProgra3BrandonArellano.ViewModel
{
    public class ListaPaisesViewModel : BindableObject
    {
        private readonly PaisBDRepository _bdRepo;

        public ObservableCollection<ModeloBBDD> Paises { get; }

        public ListaPaisesViewModel()
        {
            _bdRepo = new PaisBDRepository("scordova_bd.db");
            Paises = _bdRepo.ObtenerPaises();
        }
    }
}
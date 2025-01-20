using ExamenProgra3BrandonArellano.Repository;
namespace ExamenProgra3BrandonArellano;

public partial class Pagina2 : ContentPage
{
    private readonly BrandonSqlite _baseDatos;
    public Pagina2()
	{
		InitializeComponent();
        _baseDatos = App.Database;
        CargarHistorial();
    }
}
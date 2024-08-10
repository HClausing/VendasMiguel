using System.ComponentModel;

namespace VendasMiguel.Viewmodels;

public class Ordem : INotifyPropertyChanged
{
    public Ordem()
    {
        NovaVenda();
    }

    private Models.Ordem? _venda;

    public Models.Ordem? Venda
    {
        get => _venda;
        set 
        {
            _venda = value;
            PropertyChanged?.Invoke(this, new(nameof(Venda)));
        }
    }



    public void NovaVenda()
    {

    }



    public event PropertyChangedEventHandler? PropertyChanged;

}

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
        Venda = new()
        {
            Id = Guid.NewGuid(),
            Itens =
            [
                new Models.OrdemItem()
                {
                    Produto = new()
                    {
                        Id = 1,
                        Nome = "Hamburger",
                        Preco = 14.9M
                    },
                    Quantidade = 0.0M
                },
                new Models.OrdemItem()
                {
                    Produto = new()
                    {
                        Id = 2,
                        Nome = "Refrigerante",
                        Preco = 14.9M
                    },
                    Quantidade = 0.0M
                }
            ],
            Total = 0.00M
        };
    }



    public event PropertyChangedEventHandler? PropertyChanged;

}

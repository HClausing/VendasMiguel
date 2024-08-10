using System.Collections.ObjectModel;

namespace VendasMiguel.Models;

public class Ordem
{
    public Guid Id { get; set; }
    public ICollection<OrdemItem> Itens { get; set; } = new ObservableCollection<OrdemItem>();
    public decimal Total { get; set; }
}

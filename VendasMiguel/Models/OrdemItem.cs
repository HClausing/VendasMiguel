namespace VendasMiguel.Models;

public class OrdemItem
{
    public Produto? Produto { get; set; }
    public decimal? Quantidade { get; set; }
    public decimal? Total { get; set; }
}

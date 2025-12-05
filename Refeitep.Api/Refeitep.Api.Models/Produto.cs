namespace Refeitep.Api.Models;

public class Produto
{
    public int Id { get; set; }
    public double Estoque { get; set; }
    public double Preco { get; set; }
    public double Custo { get; set; }
//    public virtual ICollection<Pedidoitem>? Pedidoitens { get; set; }

}
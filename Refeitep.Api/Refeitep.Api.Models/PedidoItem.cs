namespace Refeitep.Api.Models;

public class Produto;
public class PedidoItem
{
    public int Id { get; set; }

    public double Qtde { get; set; }

    public double Total { get; set; }


    public int PedidoId { get; set; }

    public virtual Pedido? Pedido { get; set; }
    
    public int ProdutoId { get; set; }

    public virtual Produto? Produto { get; set; }
}

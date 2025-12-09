namespace Refeitep.Api.Models;

public class Pedido
{
    public int Id { get; set; }

    public string? PedidoStatusEnum { get; set; }

    public virtual DateTime Data  { get; set; }

    public double Total { get; set; }

    public int ClienteId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public int DispositivoId { get; set; }

    public virtual Dispositivo? Dispositivo { get; set; }

    public virtual ICollection<PedidoItem>? PedidoItens { get; set; }

}

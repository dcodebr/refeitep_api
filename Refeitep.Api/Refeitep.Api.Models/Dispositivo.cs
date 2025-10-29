namespace Refeitep.Api.Models;

public class Dispositivo
{
    public int Id { get; set; }
    public string? DeviceInfo { get; set; }
    public string? Token { get; set; }
    public virtual ICollection<object>? Pedidos { get; set; }
}

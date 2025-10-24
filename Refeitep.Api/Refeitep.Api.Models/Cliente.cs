namespace Refeitep.Api.Models;

public class Cliente
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
    public string Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? RA { get; set; }
}

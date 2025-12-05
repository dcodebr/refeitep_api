using Refeitep.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Refeitep.Api.Repositories
{
    public class ClienteRepository
    {
        private List<Cliente> _clientes = new();

        public List<Cliente> GetAll()
        {
            return _clientes;
        }

        public Cliente GetById(int id)
        {
            foreach (var c in _clientes)
                if (c.Id == id) return c;
            return null;
        }

        public void Add(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            for (int i = 0; i < _clientes.Count; i++)
            {
                if (_clientes[i].Id == cliente.Id)
                {
                    _clientes[i].UsuarioId = cliente.UsuarioId;
                    _clientes[i].Usuario = cliente.Usuario;
                    _clientes[i].Cpf = cliente.Cpf;
                    _clientes[i].DataNascimento = cliente.DataNascimento;
                    _clientes[i].RA = cliente.RA;
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _clientes.Count; i++)
            {
                if (_clientes[i].Id == id)
                {
                    _clientes.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

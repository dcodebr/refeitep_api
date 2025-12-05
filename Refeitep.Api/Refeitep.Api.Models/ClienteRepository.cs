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

    public class UsuarioRepository
    {
        private List<Usuario> _usuarios = new();

        public List<Usuario> GetAll()
        {
            return _usuarios;
        }

        public Usuario GetById(int id)
        {
            foreach (var u in _usuarios)
                if (u.Id == id) return u;
            return null;
        }

        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            for (int i = 0; i < _usuarios.Count; i++)
            {
                if (_usuarios[i].Id == usuario.Id)
                {
                    _usuarios[i].Nome = usuario.Nome;
                    _usuarios[i].Email = usuario.Email;
                    _usuarios[i].Senha = usuario.Senha;
                    _usuarios[i].Clientes = usuario.Clientes;
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _usuarios.Count; i++)
            {
                if (_usuarios[i].Id == id)
                {
                    _usuarios.RemoveAt(i);
                   break;
            }
        }
    }
}


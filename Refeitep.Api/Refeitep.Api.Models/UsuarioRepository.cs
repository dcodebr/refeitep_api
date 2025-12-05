using Refeitep.Api.Data;
using Refeitep.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Refeitep.Api.Repositories
{
    public class UsuarioRepository
    {
        private readonly RefeitepContext _context;

        public UsuarioRepository(RefeitepContext context)
        {
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.Id == id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}

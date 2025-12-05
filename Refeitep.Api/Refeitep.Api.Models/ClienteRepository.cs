using Refeitep.Api.Data;
using Refeitep.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Refeitep.Api.Repositories
{
    public class ClienteRepository
    {
        private readonly RefeitepContext _context;

        public ClienteRepository(RefeitepContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}

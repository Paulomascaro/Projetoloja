using Projetoloja.backend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetoloja.backend.respositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuariosAsync();
        Task<Usuario> GetUsuarioByIdAsync(int id);
        Task AddUsuarioAsync(Usuario usuario);
        Task UpdateUsuarioAsync(Usuario usuario);
        Task DeleteUsuarioAsync(int id);
    }
    
}

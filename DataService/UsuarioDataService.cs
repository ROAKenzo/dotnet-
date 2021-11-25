using backend.DataService.Context;
using backend.DataService.Models;

namespace backend.DataService
{
    public class UsuarioDataService
    {
        public void insertar(Usuario usuario)
        {
            using(var context = new contexto())
            {
                context.Database.EnsureCreated();
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }
    }
}
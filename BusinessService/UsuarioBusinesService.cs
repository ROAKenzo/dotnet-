using backend.DataService;
using backend.DataService.Models;

namespace backend.BusinessService
{
    public class UsuarioBusinesService
    {
        UsuarioDataService  UsuarioDataService=new UsuarioDataService();

        public void insertar(Usuario usuario){
            UsuarioDataService.insertar(usuario);
        }
    }
}
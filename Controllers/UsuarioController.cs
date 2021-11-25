using backend.BusinessService;
using backend.DataService.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
        
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController
    {
        UsuarioBusinesService ubs=new UsuarioBusinesService();
        [HttpPost]
        public ActionResult Post ([FromBody] Usuario usuario)
        {
            ubs.insertar(usuario);
            
            return new CreatedAtRouteResult("ObtenerAutor","");
        }
    }
}
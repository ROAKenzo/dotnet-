
using backend.DataService.Models;
using Microsoft.EntityFrameworkCore;
namespace backend.DataService.Context
{
    
    public class contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            
            optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=Kenzo98@");

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Usuario>( usuario=>{
                usuario.HasKey(e=>e.Id);
                usuario.Property(e=>e.Nombre).IsRequired();
                usuario.Property(e=>e.Apellidos);
                usuario.Property(e=>e.Activo);

            });
            
        }

    public DbSet<Usuario> Usuarios { get; set; }
    
}
}
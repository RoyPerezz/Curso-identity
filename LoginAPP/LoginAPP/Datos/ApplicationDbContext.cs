using LoginAPP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginAPP.Datos
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Agregamos los diferentes modelos
        public DbSet<AppUsuario> AppUsuario { get; set; }
    }
}

/*Inicializando la bd Roles con sus tablas y los roles necesarios*/
using dacodes_APICORE.Models;
using System.Linq;

namespace dacodes_APICORE
{
  public static class DbInitializer
  {
    public static void Initialize(ApiDbContext ctx)
    {
      ctx.Database.EnsureCreated();
      if (!ctx.Roles.Any())
      {
        ctx.Roles.Add(new Role { Name = "Estudiante", Active = true });
        ctx.Roles.Add(new Role { Name = "Profesor", Active = true });
        ctx.SaveChanges();
      }
    }
  }
}
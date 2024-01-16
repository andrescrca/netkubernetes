using Microsoft.AspNetCore.Identity;
using NetKubernetes.Models;

namespace NetKubernetes.Data;

public class LoadDatabase {

    public static async Task InsertarData(AppDbContext context, UserManager<Usuario> usuarioManager)
    {
        if(!usuarioManager.Users.Any())
        {
            var usuario = new Usuario {
                Nombre = "Andres",
                Apellido = "Agustin",
                Email = "andrescrca@hotmail.com",
                UserName = "andrescrca",
                Telefono = "98142545"
            };

            await usuarioManager.CreateAsync(usuario, "Wasd0790@0790");

            
        }

        if(!context.Inmuebles!.Any())
        {
            context.Inmuebles!.AddRange(
                new Inmueble{
                    Nombre = "Casa de Playa",
                    Direccion = "Av. El Sol 32",
                    Precio = 4500M,
                    FechaCreacion = DateTime.Now
                },
                new Inmueble{
                    Nombre = "Casa de Invierno",
                    Direccion = "Av. La Roca 101",
                    Precio = 3500M,
                    FechaCreacion = DateTime.Now
                }
            );
        }
        
        context.SaveChanges();
    }

}
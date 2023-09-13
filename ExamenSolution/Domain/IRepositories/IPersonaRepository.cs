using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPersonaRepository
    {
        Task<List<Persona>> ObtenerUltimas10MayoresDe21();
        Task AgregarPersona(Persona persona);
    }
}

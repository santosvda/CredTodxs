using System.Collections.Generic;
using System.Threading.Tasks;
using CredTodxs.Domain;

namespace CredTodxs.Repository.Interfaces
{
    public interface IOfertaRepository
    {
         List<Oferta> PostOferta();
         
    }
}
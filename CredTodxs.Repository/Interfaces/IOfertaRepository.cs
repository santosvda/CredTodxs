using System.Threading.Tasks;
using CredTodxs.Domain;

namespace CredTodxs.Repository.Interfaces
{
    public interface IOfertaRepository
    {
         Oferta PostOferta(Oferta model);
         
    }
}
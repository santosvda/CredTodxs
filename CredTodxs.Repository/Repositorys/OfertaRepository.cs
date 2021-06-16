using System.Threading.Tasks;
using CredTodxs.Domain;
using CredTodxs.Repository.Interfaces;

namespace CredTodxs.Repository.Repositorys
{
    public class OfertaRepository : IOfertaRepository
    {
         public Oferta PostOferta(Oferta model){

            return model;
        }
    }
}
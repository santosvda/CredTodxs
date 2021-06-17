using System.Collections.Generic;
using System.Threading.Tasks;
using CredTodxs.Domain;
using CredTodxs.Repository.Interfaces;

namespace CredTodxs.Repository.Repositorys
{
    public class OfertaRepository : IOfertaRepository
    {
         public List<Oferta> PostOferta(){
             List<Oferta> model = new List<Oferta>();
             model.Add(new Oferta());
             model.Add(new Oferta());
            return model;
        }
    }
}
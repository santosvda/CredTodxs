using CredTodxs.Domain.Enums;

namespace CredTodxs.Domain
{
    public class Solicitacao
    {
        public int Id {get; set;}
        public int IdPessoa {get; set;}
        public Pessoa Pessoa {get; set;}
        public double QtdSolicitada {get; set;}
        public double RendaMensal {get; set;}
        public Residencia Residencia {get; set;}
        public bool Brasileiro {get; set;}
        public string CidadeNatal {get; set;}
        public string UfNatal {get; set;}
        public string NomeMae {get; set;}
        
    }
}
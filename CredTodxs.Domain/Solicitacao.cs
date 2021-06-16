namespace CredTodxs.Domain
{
    public class Solicitacao
    {
        public int Id {get; set;}
        public int IdPessoa {get; set;}
        public Pessoa Pessoa {get; set;}
        public decimal QtdSolicitada {get; set;}
        public decimal RendaMensal {get; set;}
        public int Residencia {get; set;}
        public bool Brasileiro {get; set;}
        public string CidadeNatal {get; set;}
        public string UfNatal {get; set;}
        public string NomeMae {get; set;}
        
    }
}
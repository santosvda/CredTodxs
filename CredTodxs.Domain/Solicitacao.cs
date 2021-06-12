namespace CredTodxs.Domain
{
    public class Solicitacao
    {
        int Id {get; set;}
        int IdPessoa {get; set;}
        decimal QtdSolicitada {get; set;}
        decimal RendaMensal {get; set;}
        int Residencia {get; set;}
        bool Brasileiro {get; set;}
        string CidadeNatal {get; set;}
        string UfNatal {get; set;}
        string NomeMae {get; set;}
        
    }
}
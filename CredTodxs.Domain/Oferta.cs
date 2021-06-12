using System;

namespace CredTodxs.Domain
{
    public class Oferta
    {
        int Id {get; set;}
        int IdSolicitacao {get; set;}
        int QtdParcelas {get; set;}
        decimal ValorParcelas {get; set;}
        decimal Cet {get; set;}
        decimal Juros {get; set;}
        int FormaPagamento {get; set;}
        DateTime DataVencimento {get; set;}
        int TipoCredito {get; set;}
    }
}
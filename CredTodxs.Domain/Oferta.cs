using System;

namespace CredTodxs.Domain
{
    public class Oferta
    {
        public int Id {get; set;}
        public int IdSolicitacao {get; set;}
        public Solicitacao Solicitacao {get; set;}
        public int QtdParcelas {get; set;}
        public decimal ValorParcelas {get; set;}
        public decimal Cet {get; set;}
        public decimal Juros {get; set;}
        public int FormaPagamento {get; set;}
        public DateTime DataVencimento {get; set;}
        public int TipoCredito {get; set;}
    }
}
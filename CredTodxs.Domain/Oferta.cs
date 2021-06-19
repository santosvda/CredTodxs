using System;
using CredTodxs.Domain.Enums;

namespace CredTodxs.Domain
{
    public class Oferta
    {
        public int Id {get; set;}
        public int IdSolicitacao {get; set;}
        public Solicitacao Solicitacao {get; set;}
        public string NomeEmpresa {get; set;}
        public int QtdParcelas {get; set;}
        public double TotalPagar {get; set;}
        public double ValorParcelas {get; set;}
        public double CetMensal {get; set;}
        public double CetAnual {get; set;}
        public double Juros {get; set;}
        public FormaPagamento FormaPagamento {get; set;}
        public DateTime DataPrimeiroVencimento {get; set;}
    }
}
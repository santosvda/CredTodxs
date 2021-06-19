using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CredTodxs.Domain;
using CredTodxs.Domain.Enums;
using CredTodxs.Repository.Interfaces;

namespace CredTodxs.Repository.Repositorys
{
    public class OfertaRepository : IOfertaRepository
    {
        public List<Oferta> GeraOfertas(Solicitacao solicitacao)
        {
            int qtdOfertas = new Random().Next(1, 3);

            List<Oferta> ofertas = new List<Oferta>();

            for(int i = 0; i <= qtdOfertas; i++)
            {
                Oferta oferta = new Oferta();
                oferta.Solicitacao = solicitacao;

                oferta.Juros = new Random().Next(10, 15);
                oferta.QtdParcelas = new Random().Next(12, 23);
                oferta.DataPrimeiroVencimento = DateTime.Now.AddDays(30);


                oferta.ValorParcelas = CalculaParcela(oferta.Juros,oferta.QtdParcelas, solicitacao.QtdSolicitada);
                oferta.TotalPagar = oferta.ValorParcelas * oferta.QtdParcelas;

                oferta.CetMensal = CalculaCETMensal(oferta.TotalPagar, oferta.ValorParcelas, oferta.QtdParcelas);
                oferta.CetAnual = CalculaCETAnual(oferta.TotalPagar, oferta.ValorParcelas, oferta.QtdParcelas,DateTime.Now, oferta.DataPrimeiroVencimento);

                oferta.FormaPagamento = (FormaPagamento)new Random().Next(1, 2);

                ofertas.Add(oferta);

            }


            return ofertas;
        }

        public double CalculaParcela(double taxaJuros, int qtdParcelas, double valorInicial)
        {
            double pagamento = (valorInicial * Math.Pow((taxaJuros / 12) + 1, (qtdParcelas)) * taxaJuros / 12)
                                    / (Math.Pow(taxaJuros / 12 + 1, (qtdParcelas)) - 1);
            return pagamento;
        }

        public double CalculaCETMensal(double valorFinanciado, double valorParcela, int n)
        {
            double CET_MAXVALUE = 10000.00;
            double CET_PRECISION = 0.00001;

            double cet = 0.0;

            while (true)
            {
                double total = 0.0;

                for (int j = 0; j < n; j++)
                {
                    total += valorParcela / Math.Pow(1.0 + cet, j + 1);
                }

                cet += CET_PRECISION;

                if (cet >= CET_MAXVALUE)
                {
                    return -1.0;
                }
                if (total - valorFinanciado <= 0)
                {
                    break;
                }
                else
                {
                    cet *= total / valorFinanciado;
                }
            }
            return cet * 100.0;
        }

        public double CalculaCETAnual(double valorFinanciado, double valorParcela, int prazo, DateTime dataContrato, DateTime dataPrimeiroVencimento)
        {
            double CET_MAXVALUE = 10000;
            double CET_PRECISION = 0.00001;
            double cet = 0;

            while (true)
            {
                DateTime c = new DateTime();
                DateTime dj = new DateTime();
                double total = 0.0;

                for (int j = 0; j < prazo; j++)
                {
                    dj = dataPrimeiroVencimento;
                    if (j != 0)
                    {
                        c = dataPrimeiroVencimento;
                        dj = c.AddMonths(j);
                    }
                    double days = (dj - dataContrato).Days;
                    total += valorParcela / Math.Pow(1 + cet, days / 365);
                }

                cet += CET_PRECISION;

                if (cet >= CET_MAXVALUE)
                {
                    return -1;
                }
                if (total - valorFinanciado <= 0)
                {
                    break;
                }
                else
                {
                    cet *= total / valorFinanciado;
                }
            }

            return cet * 100;
        }
    }
}
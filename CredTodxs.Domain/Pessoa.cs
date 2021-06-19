using System;
using CredTodxs.Domain.Enums;

namespace CredTodxs.Domain
{
    public class Pessoa
    {
        public int Id {get; set;}
        public string Telefone {get; set;}
        public string Email {get; set;}
        public EstadoCivil EstadoCivil {get; set;}
        public Escolaridade Escolaridade {get; set;}
        public char Sexo {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Cpf {get; set;}
        public string Rg {get; set;}
        public string Cep {get; set;}
        public string Cidade {get; set;}
        public string Uf {get; set;}
        public string Logradouro {get; set;}
        public string Bairro {get; set;}
        public string Complemento {get; set;}
        public int Numero {get; set;}
    }
}
using System;

namespace CredTodxs.Domain
{
    public class Pessoa
    {
        int Id {get; set;}
        string Telefone {get; set;}
        string Email {get; set;}
        int EstadoCivil {get; set;}
        int Escolaridade {get; set;}
        char Sexo {get; set;}
        DateTime DataNascimento {get; set;}
        string Cpf {get; set;}
        string Rg {get; set;}
        string Cep {get; set;}
        string Cidade {get; set;}
        string Uf {get; set;}
        string Logradouro {get; set;}
        string Bairro {get; set;}
        string Complemento {get; set;}
        int Numero {get; set;}
    }
}
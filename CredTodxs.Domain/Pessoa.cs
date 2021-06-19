using System;
using System.ComponentModel.DataAnnotations;
using CredTodxs.Domain.Enums;

namespace CredTodxs.Domain
{
    public class Pessoa
    {
        public int Id {get; set;}
        [Required(ErrorMessage = "Telefone: é obrigatório ser informado.")]
        [StringLength(11, MinimumLength = 8, ErrorMessage = "Por favor informe um numero de telefone válido: o mesmo deve conter entre 8 a 13 caracteres.")]
        public string Telefone {get; set;}
        [Required(ErrorMessage = "Por favor, informe um nome válido.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "O 'Nome' deve conter um minimo de 5 caracteres e máximo de 60.")]
        public string Nome {get; set;}
        [Required(ErrorMessage = "Email: é obrigatório ser informado.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um endereço de email válido.")]
        public string Email {get; set;}
        [Required(ErrorMessage = "Estado Civil: é obrigatório ser informado.")]
        public EstadoCivil EstadoCivil {get; set;}
        [Required(ErrorMessage = "Escolaridade: é obrigatório ser informado.")]
        public Escolaridade Escolaridade {get; set;}
        [Required(ErrorMessage = "Sexo: é obrigatório ser informado.")]
        public char Sexo {get; set;}
        [Required(ErrorMessage = "Data de Nascimento: é obrigatório ser informado.")]
        public DateTime DataNascimento {get; set;}
        [Required(ErrorMessage = "CPF: é obrigatório ser informado")]
        [StringLength(14, MinimumLength = 0, ErrorMessage = "Por favor, informe um CPF válido!")]
        public string Cpf {get; set;}
        [Required(ErrorMessage = "RG: é obrigatório ser informado")]
        [StringLength(14, MinimumLength = 0, ErrorMessage = "Por favor, informe um RG válido!")]
        public string Rg {get; set;}
        [Required(ErrorMessage = "CEP: é obrigatório ser informado")]
        [StringLength(8, MinimumLength = 0, ErrorMessage = "Por favor, informe um CEP válido!")]
        public string Cep {get; set;}
        [Required(ErrorMessage = "Cidade: é obrigatório ser informado")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Cidade deve conter um máximo de 30 caracteres.")]
        public string Cidade {get; set;}
        [Required(ErrorMessage = "Estado: é obrigatório ser informado")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Informe apenas as siglas do seus estado, totalizando 2 caracteres.")]
        public string Uf {get; set;}
        [Required(ErrorMessage = "Rua: é obrigatório ser informado")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Rua deve conter um máximo de 30 caracteres.")]
        public string Logradouro {get; set;}
        [Required(ErrorMessage = "Bairro: é obrigatório ser informado")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Bairro deve conter um máximo de 30 caracteres.")]
        public string Bairro {get; set;}
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Complemento deve conter um máximo de 100 caracteres.")]
        public string Complemento {get; set;}
        [Required(ErrorMessage = "Número: é obrigatório ser informado")]
        public int Numero {get; set;}
    }
}
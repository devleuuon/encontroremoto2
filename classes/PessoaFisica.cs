using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastroPessoas.interfaces;

namespace cadastroPessoas.classes
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}
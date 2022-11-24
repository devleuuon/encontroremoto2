using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroPessoas.interfaces
{
    public interface IpessoaFisica
    {
        public bool ValidarDataNascimento (DateTime dataNasc);
    }
}
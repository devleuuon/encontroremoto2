using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastroPessoas.interfaces;

namespace cadastroPessoas.classes
{
    public class pessoa : Ipessoa
    {
public string ?nome {get;set;}

public string ?endereco {get;set;}

public float ?rendimento {get;set;}


        float Ipessoa.PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}
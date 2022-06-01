using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class ProblemasAtivarDesativar
    {
        public static Funcionario AtivarRegistro(int codigo)
        {
            Funcionario teste = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun=> fun.Codigo == codigo);
            if (teste != null)
            {
                teste.Situacao = Atacado.Modelo.Ancestral.SituacaoEnum.Ativo;
                ProblemasFuncionario.Exercicio05(teste);
            }
            return teste;
        }

        public static Funcionario DesativarRegistro(int codigo)
        {
            Funcionario teste = FuncionarioFakeDB.Funcionarios.SingleOrDefault(fun => fun.Codigo == codigo);
            if (teste != null)
            {
                teste.Situacao = Atacado.Modelo.Ancestral.SituacaoEnum.Inativo;
                ProblemasFuncionario.Exercicio05(teste);
            }
            return teste;
        }


    }
}

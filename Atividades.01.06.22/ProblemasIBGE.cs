using Atacado.Modelo.IBGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class ProblemasIBGE
    {
        public static void Exercicio09(Estado sigla)
        {
            Console.Write("Sigla: {0} ", sigla.SiglaUF);
            Console.Write("Nome: {0} ", sigla.Codigo);
            Console.Write("Nome: {0} ", sigla.RegiaoBrasil);
            Console.Write("Nome: {0} ", sigla.Descricao);
        }

        public static void Exercicio10(Municipio estado)
        {
            Console.Write("Sigla: {0} ", estado.SiglaUF);
            Console.Write("Sigla: {0} ", estado.Descricao);
            Console.Write("Sigla: {0} ", estado.Codigo);
            Console.Write("Sigla: {0} ", estado.CodigoUF);
            Console.Write("Sigla: {0} ", estado.CodigoIBGE6);
            Console.Write("Sigla: {0} ", estado.CodigoIBGE7);
        }

        public static void Exercicio11(Estado estado)
        {
            Console.Write("Sigla: {0} ", estado.SiglaUF);
            Console.Write("Sigla: {0} ", estado.Descricao);
            Console.Write("Sigla: {0} ", estado.Codigo);     
        }   
    
    }
}

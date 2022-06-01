using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class ProblemasMatematicos
    {
        public static int Exercicio01(Operacoes op, int num1, int num2)
        {
            int result = 0;
            switch (op)
            {
                case Operacoes.Adicao:
                    result = num1 + num2;
                    break;
                case Operacoes.Subtracao:
                    result = num1 - num2;
                    break;
                case Operacoes.Divisao:
                    result = num1 / num2;
                    break;
                case Operacoes.Multiplicacao:
                    result = num1 * num2;
                    break;
                default:
                    break;
            }
            return result;
        }
        public static double Exercicio02( double comprimento, double altura, double largura)
        {
            double result = 0;
            result = comprimento * altura * largura;
            return result;
        }
        public static double Exercicio03( double altura, double raio)
        {
            double result = Math.PI * altura * Math.Pow(raio,2);
            return result;
        }
        public static double Exercicio04(double raio)
        {
            double result = (4 * Math.PI * Math.Pow(raio, 3)) / 3 ;
            return result;
        }
    }   
}

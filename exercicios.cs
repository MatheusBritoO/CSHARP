using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Encontro21_Codigo01();
            //Encontro_Codigo02();
            //Desafio_001();
            //Desafio_002();
            //Desafio_003();
            //Desafio_004();
            //Desafio_005();

            Console.ReadLine();
        }
------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Encontro21_Codigo01()
        {
            Console.WriteLine("Testando o laço while...");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Testando o laço do...while");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
------------------------------------------------------------------------------------------------------------------------------------

        public static void Encontro_Codigo02()
        {
            int parada = 45;
            for (int i = 0; i < parada; i++)
            {
                Console.WriteLine("Mensagem {0} de {1}.", i, parada);           
            }
            Console.WriteLine("Laço for terminou.");
        }
-----------------------------------------------------------------------------------------------------------------------
        public static void Desafio_001()
        {
            Console.WriteLine("Informe um valor: ");
            string valor = Console.ReadLine();
            int num = Convert.ToInt32(valor);
            int dobro = num * 2;
            int triplo = num * 3;
            double raiz = Math.Sqrt(num);

            Console.WriteLine("O dobro de {0} vale {1}", valor, dobro);
            Console.WriteLine("O Triplo de {0} vale {1}", valor, triplo);
            Console.WriteLine("A raiz quadrada de {0} vale {1}", valor, raiz);

        }

----------------------------------------------------------------------------------------------------
        public static void Desafio_002()
        {
            Console.WriteLine("Informe sua nota 1: ");
            string nota1 = Console.ReadLine();            
           int num = Convert.ToInt32(nota1);


            Console.WriteLine("Informe sua nota 2: ");
            string nota2 = Console.ReadLine();
            int num2 = Convert.ToInt32(nota2);

            double media = (num + num2) / 2;
            Console.WriteLine("O valor da sua média é {0}",media);

        }

------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_003()
        {
            Console.WriteLine("Informe o numero de metros: ");
            string metros = Console.ReadLine();
            int num = Convert.ToInt32(metros);

            int cent = num * 100;
            int milim = num * 1000;

            Console.WriteLine("O valor em centimetros é {0} e o valor em milimetros é {1}", cent, milim);
        }
-----------------------------------------------------------------------------------------------------------------
        public static void Desafio_004()
        {
            Console.WriteLine("Informe o numero: ");
            string tab = Console.ReadLine();
            int num = Convert.ToInt32(tab);


            for (int i = 1; i < 11;i++)
            {
                int resul = num * i;


                Console.WriteLine("{0} x {1}= {2}", i,num , resul);

            }
        }

---------------------------------------------------------------------------------------------------
        public static void Desafio_005()
            {

            Console.WriteLine("Informe o numero US$: ");
            string us = Console.ReadLine();
            decimal num = Convert.ToDecimal(us);

            decimal reais = num * 5;
            Console.WriteLine("O valor em reais é {0}", reais);
            }
    }
}

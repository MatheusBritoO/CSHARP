using Atacado.FakeDB.RH;
using Atacado.Modelo.RH;
using DesafiosDaGripe01;

namespace DesafiosDaGripe
{
   
    public class Program
    {   
       
        public static void Main(string[]args)
        {
            //ExecutarExercicio01();
            //ExecutarExercicio02();
            //ExecutarExercicio03();
            //ExecutarExercicio06();
            //ExecutarExercicio05();
            //ExecutarExercicio06();
            //ExecutarExercicio07();
            //ExecutarExercicio08();           
            Console.ReadLine();
        }
        public static void ExecutarExercicio01()
        {
            int menu = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (menu)
            {
                case 0:
                    result = ProblemasMatematicos.Exercicio01(Operacoes.Adicao, num1, num2);
                 break;
                 case 1:
                    result = ProblemasMatematicos.Exercicio01(Operacoes.Subtracao, num1, num2);
                    break;
                case 2:
                    result = ProblemasMatematicos.Exercicio01(Operacoes.Multiplicacao, num1, num2);
                    break;
                case 3:
                    result = ProblemasMatematicos.Exercicio01(Operacoes.Divisao, num1, num2);
                    break;
                default:
                    break;       
            }
            Console.WriteLine("Resultado {0}", result);
        }


        public static void ExecutarExercicio02()
        {
            Console.WriteLine("Informe o comprimento");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura");
            double largura = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            result = ProblemasMatematicos.Exercicio02(comprimento, altura, largura);
            Console.WriteLine("Resultado {0}", result);
        }

        public static void ExecutarExercicio03()
        {           
            Console.WriteLine("Informe a altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o raio");
            double raio = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            result = ProblemasMatematicos.Exercicio03( altura, raio);
            Console.WriteLine("Resultado {0}", result);
        }

        public static void ExecutarExercicio04()
        {
            Console.WriteLine("Informe o raio");
            double raio = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            result = ProblemasMatematicos.Exercicio04(raio);
            Console.WriteLine("Resultado {0}", result);
        }

        public static void ExecutarExercicio05()
        {
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(empregado => empregado.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                ProblemasFuncionario.Exercicio05(i);
            }
        }

        public static void ExecutarExercicio06()
        {
            Console.WriteLine("Informe o peso do funcionário: ");
            float peso = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe a altura do funcionário: ");
            float altura = Convert.ToSingle(Console.ReadLine());
            ProblemasFuncionario.Exercicio06(peso, altura);
        }

        public static void ExecutarExercicio07()
        {
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                ProblemasFuncionario.Exercicio07(i);
            }
        }

        public static void ExecutarExercicio08()
        {
            Console.WriteLine("Informe o código do funcionário (1 até 100): ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            List<Funcionario> funcionario = FuncionarioFakeDB.Funcionarios.Where(pes => pes.Codigo == codigo).ToList();
            foreach (Funcionario i in funcionario)
            {
                ProblemasFuncionario.Exercicio08(i);
            }
        }
    }
 }

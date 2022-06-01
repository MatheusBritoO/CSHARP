using Atacado.FakeDB.RH;
using Atacado.Modelo.IBGE;
using Atacado.Modelo.RH;
using DesafiosDaGripe01;
using FakeDB.IBGE;

namespace DesafiosDaGripe
{
   
    public class Program
    {   
       
        public static void Main(string[]args)
        {
                   
            ExecutarExercicio09();
            ExecutarExercicio10();
            ExecutarExercicio11();
            ExecutarExercicio12();
            ExecutarExercicio13();
            Console.ReadLine();
        }
        public static void ExercutarExercicio09()
        {
            while (true)
            {
                Console.Write("Digite uma Sigla de Estado: ");
                string sigla = Console.ReadLine();
                if (sigla.Length != 2)
                {
                    Console.WriteLine("Sigla não encontrada, digite novamente!");
                }
                List<Estado> estados = EstadoFakeFB.Estados.Where(pes => pes.SiglaUF == sigla).ToList();
                Console.WriteLine("número de Siglas encontradas: {0}.", estados.Count());
                foreach (Estado item in estados)
                {
                    ProblemasIBGE.Exercicio09(item);
                }
            }
        }

        public static void ExecutarExercicio010()
        {
            Console.WriteLine("Digite a sigla: ");
            string sigla = Console.ReadLine();
            List<Municipio> municipios = MunicipioFakeDB.Municipios.Where(pes => pes.SiglaUF == sigla).ToList();
            if (sigla.Length != 2)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in municipios)
                {
                    ProblemasIBGE.Exercicio10(item);
                }
            }
        }

        public static void ExecutarExercicio11()
        {
            Console.WriteLine("-Lista para mostrar todos os estados da região desejada-");
            Console.WriteLine("Escolha a região desejada: ");
            string regiao = Console.ReadLine();
            List<Estado> estados = EstadoFakeFB.Estados.Where(pes => pes.RegiaoBrasil.StartsWith(regiao)).ToList();
            Console.WriteLine("Estados da regiao {0}:", regiao);
            if (estados.Count() == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Estado item in estados)
                {
                    ProblemasIBGE.Exercicio11(item);
                }
            }
        }
    
        public static void ExecutarExercicio12()
        {
            Console.WriteLine("Digite o código desejado para ativar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasAtivarDesativar.AtivarRegistro(codigo);
        }

        public static void ExecutarExercicio13()
        {
            Console.WriteLine("Digite o código desejado para desativar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            ProblemasAtivarDesativar.DesativarRegistro(codigo);
        }


    }
 }

using Cap202204ConsoleApp.Encontro31;
using Cap202204ConsoleApp.FakeDB;
using Cap202204ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp.Desafios

{
    /// <summary>
    /// 9 - Criar um método que pesquise um Município pelo Código IBGE 7.
    ///10 - Criar um método que pesquise um Município pelo CEP.
    /// </summary>
    public class Desafio046
    {
        private List<Estado> lista01;
        private List<Estado> lista02;
        private List<Estado> lista03;
        private List<Municipio> lista04;
        private List<Municipio> lista05;
        private List<Municipio> lista09;
        private List<Municipio> lista10;

        public Desafio046()
        {
            this.lista01 = new List<Estado>();
            this.lista02 = new List<Estado>();
            this.lista03 = new List<Estado>();
            this.lista04 = new List<Municipio>();
            this.lista05 = new List<Municipio>();
            this.lista09 = new List<Municipio>();
            this.lista10 = new List<Municipio>();
        }


        public void Executar()
        {
            this.Exercicio04();
            this.Exercicio05();
            this.Exercicio06();
            this.Exercicio07();
            this.Exercicio08();
            this.Exercicio09();
            this.Exercicio10();
        }
        /// <summary>
        ///  4 - Criar um método que pesquise um Estado pelo Nome.
        /// </summary>

        private void Exercicio04()
        {
            Console.Write("Digite o nome de um Estado: ");
            string nome = Console.ReadLine();
            this.lista01 = EstadoFakeDB.Estados.Where(pes => pes.Nome.StartsWith(nome)).ToList();
            Console.WriteLine("número de estados encontrados: {0}.", this.lista01.Count());
            foreach (Estado item in this.lista01)
            {
                Console.WriteLine("- Estado encontrado -");
                Console.WriteLine("{0} | {1}", item.Nome, item.Siglauf);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 5 - Criar um método que pesquise um Estado pela Sigla.
        /// </summary>

        private void Exercicio05()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Digite uma Sigla de Estado: ");
                string nome = Console.ReadLine();
                if (nome.Length != 2)
                {
                    Console.WriteLine("Sigla não encontrada, digite novamente!");
                }
                this.lista02 = EstadoFakeDB.Estados.Where(pes => pes.Siglauf == nome).ToList();
                Console.WriteLine("número de Siglas encontradas: {0}.", this.lista02.Count());
                foreach (Estado item in this.lista02)
                {
                    Console.WriteLine("- Sigla encontrada -");
                    Console.WriteLine("{0} | {1}", item.Siglauf, item.Nome);
                }
                Console.Write("Deseja parar (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.WriteLine();

            }
        }
        /// <summary>
        /// 6 - Criar um método que produza uma lista paralela com todos os Estados, 
        /// filtrando pela Região do Brasil (listar os dados de RegiaoBrasilFakeDB).
        /// </summary>
        private void Exercicio06()
            
        {
            Console.Clear();
            Console.WriteLine("-Lista para mostrar todos os estados da região desejada-");
            Console.WriteLine("Escolha a região desejada: ");
            string regiao = Console.ReadLine();
            this.lista03 = EstadoFakeDB.Estados
                .Where(pes => pes.Regiao.StartsWith(regiao))
                .ToList();
            Console.WriteLine("Estados da regiao {0}:", regiao);
            foreach (Estado item in this.lista03)
            {
                Console.WriteLine("{0} - Sigla: {1}", item.Nome, item.Siglauf);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 7 - Criar um método que pesquise um Município pelo Nome.
        /// </summary>
        private void Exercicio07()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Qual o município que você procura? >");
                string nomem = Console.ReadLine();

                this.lista04 = MunicipioFakeDB.Municipios.Where(pes => pes.Nome == nomem).ToList();
                foreach (var pe in this.lista04)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Codigo: {0} | Nome: {1} | SiglaUF: {2} | Ibge: {3} | Ibge7: {4} | Pop: {5} | Cep: {6}",
                        pe.Codigo, pe.Nome, pe.Siglauf, pe.Ibge, pe.Ibge7, pe.Populacao, pe.Cep);
                    Console.ResetColor();

                }
                if (this.lista04.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não existe ninguem com esse nome");
                    Console.ResetColor();
                }

                Console.Write("Deseja parar (S/N):");
                string saida = Console.ReadLine();
                if (saida.ToUpper() == "S")
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        public void Exercicio08()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO  8");
            Console.WriteLine("Digite a sigla do estado (RO): ");
            string opcao = Console.ReadLine();
            this.lista05 = MunicipioFakeDB.Municipios.Where(pes => pes.Siglauf == opcao).ToList();
            if (this.lista05.Count() == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in this.lista05)
                {
                    Console.WriteLine("  Municipio: {0} | siglaUF {1} ",
                        item.Nome,
                        item.Siglauf);
                }
            }
            Console.WriteLine("Total de Registros: {0}", this.lista05.Count());
            Console.ReadLine();
        }

        /// <summary>
        /// 9 - Criar um método que pesquise um Município pelo Código IBGE 7.
        /// </summary>

        public void Exercicio09()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO 09 --");
            Console.WriteLine("Digite o Código do IBGE: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            this.lista09 = MunicipioFakeDB.Municipios.Where(pes => pes.Ibge7 == resposta).ToList();
            if (this.lista09.Count == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in this.lista09)
                {
                    Console.WriteLine("IBGE: {0} |Código: {1} | Município: {2} | Sigla: {3} | " +
                        "População: {4} | CEP: {5} ", item.Ibge7, item.Codigo, item.Nome,
                        item.Siglauf, item.Populacao, item.Cep);
                }
            }
            Console.WriteLine("Total de Registros: {0}", this.lista09.Count());
            Console.WriteLine("-- FIM EXERCÍCIO 9 --");
            Console.ReadLine();

        }
        /// <summary>
        /// /10 - Criar um método que pesquise um Município pelo CEP.
        /// </summary>

        public void Exercicio10()
        {
            Console.Clear();
            Console.WriteLine("-- EXERCÍCIO 10 --");
            Console.WriteLine("Digite o CEP: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            this.lista10 = MunicipioFakeDB.Municipios.Where(pes => pes.Cep == resposta).ToList();
            if (this.lista10.Count == 0)
            {
                Console.WriteLine("Não existem dados a serem exibidos.");
            }
            else
            {
                foreach (Municipio item in this.lista10)
                {
                    Console.WriteLine("CEP: {0} |Código: {1} | Município: {2} | Sigla: {3} | " +
                        "População: {4} | IBGE: {5} ", item.Cep, item.Codigo, item.Nome,
                        item.Siglauf, item.Populacao, item.Ibge7);
                }

            }
            Console.WriteLine("Total de Registros: {0}", this.lista10.Count());
            Console.WriteLine("-- FIM EXERCÍCIO 10 --");
            Console.ReadLine();
        }
    }
}

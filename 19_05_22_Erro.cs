using Cap202204ConsoleApp.FakeDB;
using Cap202204ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap202204ConsoleApp.Desafios
{
    public class Desafio045
    {
        private List<Pessoa> lista1960;
        private List<Pessoa> lista1955;
        private List<Pessoa> listaMes;
        private List<Pessoa> ListaLetraA;
        private List<Pessoa> ListaNomes;
        private List<Pessoa> ListaAno;
        private List<Pessoa> listaMM;
        private List<Pessoa> listaFF;



        public Desafio045()
        {
            this.lista1960 = new List<Pessoa>();
            this.lista1955 = new List<Pessoa>();
            this.listaMes = new List<Pessoa>();
            this.ListaLetraA = new List<Pessoa>();
            this.ListaNomes = new List<Pessoa>();
            this.ListaAno = new List<Pessoa>();
            this.listaMM = new List<Pessoa>();
            this.listaFF = new List<Pessoa>();



        }
        public void Executar()
        {
            this.Pessoas1960();
            this.Pessoas1955e1960();
            this.MesPessoa();
            this.LetrasA();
            this.PesquisaNome();
            this.PesquisarPorAno();
            this.SomenteHomens();
            this.SomenteMulheres();
        }

        private void Pessoas1960()

        {
            DateTime data = Convert.ToDateTime("01-01-1960");
            DateTime dat = Convert.ToDateTime("30-12-1969");
            this.lista1960 = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento >= data && pes.DtNascimento < dat).ToList();
            Console.WriteLine("Lista década de 60");
            Console.WriteLine("Quantidade de pessoas nascidas na década de 60: {0}", this.lista1960.Count());

        }

        private void Pessoas1955e1960()

        {
            DateTime data = Convert.ToDateTime("01-01-1955");
            DateTime dat = Convert.ToDateTime("30-12-1960");
            this.lista1955 = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento >= data && pes.DtNascimento < dat).ToList();
            Console.WriteLine("Pessoas Na");
            Console.WriteLine("Quantidade de pessoas nascidas entre 1955 e 1960: {0}", this.lista1955.Count());
        }

        private void MesPessoa()
        {
            Console.WriteLine("Escolha o mes desejado: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            this.listaMes = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento.Month == mes).ToList();
            Console.WriteLine("Pessoas nascidas esse mês: {0}", this.listaMes.Count());

        }

        private void LetrasA()
        {
            this.ListaLetraA = PessoaFakeDB.Pessoa.Where(pes => pes.Nome[0] == 'A').ToList();
            foreach (Pessoa item in this.ListaLetraA)
            {
                Console.WriteLine("Pessoas com nomes começados por A: {0}", item.Nome);
            }
        }

        private void PesquisaNome()
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();
            this.ListaNomes = PessoaFakeDB.Pessoa.Where(pes => pes.Nome == nome).ToList();
            foreach (Pessoa item in this.ListaNomes)
            {
                Console.WriteLine("Nome Pesquisado: {0}", item.Nome);
            }
        }

        private void PesquisarPorAno()
        {
            Console.WriteLine("Escolha o ano de nascimento desejado: (dia/mes/ano) ");
            DateTime ano = Convert.ToDateTime(Console.ReadLine());
            this.ListaAno = PessoaFakeDB.Pessoa.Where(pes => pes.DtNascimento == ano).ToList();
            foreach (Pessoa item in this.ListaAno)
            {
                Console.WriteLine("Nome pesquisado pelo ano de nascimento: {0}", item.Nome);
            }
            if (this.ListaAno.Count() == 0)
            {
                Console.WriteLine("Tente novamente");
            }

        }

        private void SomenteHomens()
        {
            this.listaMM = this.lista1960.Where(pes => pes.Sexo == "M").ToList();
            foreach (Pessoa item in this.listaMM)
            {
                Console.WriteLine("Nomes Masculinos: {0}", item.Nome);
            }
            
        }

        private void SomenteMulheres()
        {
            this.listaFF = this.lista1960.Where(pes => pes.Sexo == "F").ToList();
            foreach (Pessoa item in this.listaFF)
            {
                Console.WriteLine("Nomes Masculinos: {0}", item.Nome);
            }

        }
    }
}

 public static void Desafio_031()
        {
            Console.WriteLine("Informe um número: ");
            string numer = Console.ReadLine();
            int num = Convert.ToInt32(numer);
            if (num % 2 == 0)                    
            {
                Console.Clear();
                Console.WriteLine("O numero {0} é par.", num);
            }
            else
            {
                Console.WriteLine("O numero {0} é impar.", num);
            }            
            for (int i = 1; i <= 1; i++)
            
                if (num % 2 == 0) 
            
                {
                Console.WriteLine("O numero {0} multiplo de 2.", num);
                }
                for (int i = 1; i <= 1; i++)
                if (num % 3 == 0)
                {
                    Console.WriteLine("O numero {0} multiplo de 3.", num);
                }
                for (int i = 1; i <= 1; i++)
                if (num % 5 == 0)
                {
                    Console.WriteLine("O numero {0} multiplo de 5.", num);
                }
        }       
 ------------------------------------------------------------------------------------------      
        public static List<string> CriarListaDeNomes2()
            {
                List<string> listaDeNomes2 = new List<string>();
                listaDeNomes2.Add("Matheus");
                listaDeNomes2.Add("Lucas");
                listaDeNomes2.Add("Julia");
                listaDeNomes2.Add("Romeu");
                listaDeNomes2.Add("Antonieta");
                listaDeNomes2.Add("Pedro");
                listaDeNomes2.Add("Tadeu");
                listaDeNomes2.Add("Tomé");
                listaDeNomes2.Add("Carlos");
                listaDeNomes2.Add("Isabela");
                listaDeNomes2.Add("Maria");
                listaDeNomes2.Add("Beatriz");
                listaDeNomes2.Add("Carol");
                listaDeNomes2.Add("Celene");
                listaDeNomes2.Add("Rosa");
                listaDeNomes2.Add("Calleri");
                listaDeNomes2.Add("Hernanes");
                listaDeNomes2.Add("Silva");
                listaDeNomes2.Add("Linda");
                listaDeNomes2.Add("Bonita");
                return listaDeNomes2;
            }
 ------------------------------------------------------------------------------------------ 
        public static void Desafio_032()
        {     
           List<string> listaDeNomes2 = CriarListaDeNomes2();
            List<int> idade = new List<int>();
            for (int i = 0; i < listaDeNomes2.Count(); i++)
            {
                Console.WriteLine("Coloque sua idade {0}: ", listaDeNomes2[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
            }
            double total = 0;
            foreach(int i in idade)
            {
                total=total+i;
            }
            double media = total / listaDeNomes2.Count();
            Console.WriteLine("A média das idades é {0}.", media);                             
        }
 ------------------------------------------------------------------------------------------ 
        public static void Desafio_033()
        {
          List<string> lista = listaDeNomes2();
            List<int> idade = new List<int>();
            int contador = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite a idade do aluno {0}: ", lista[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
                if (idade[i] > 18)
                {
                    contador++;
                }
            }
            Console.WriteLine("{0} alunos possuem mais 18 anos.", contador);
        }

 ------------------------------------------------------------------------------------------ 
        public static void Desafio_034()
        {
            int min = 1;
            int max = 1000;
            int soma = (min + max) * ((max - min + 1) / 2);
            Console.WriteLine(soma);
        }
 ------------------------------------------------------------------------------------------                  
        public static void Desafio_035()
        {
            for (int i = 3; i <= 100; i = i + 3)
            {
                Console.Write(i +"-");
            }                                      
       }
 -----------------------------------------------------------------------------------------------
       public static void Desafio_036()
        {
            List<string> lista = listaDeNomes2();
            List<int> idade = new List<int>();
            List<string> pais = new List<string>();
            int contador = 0;
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.Write("Digite a idade do aluno {0}: ", lista[i]);
                idade.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Digite a nacionalidade do aluno {0}: ", lista[i]);
                pais.Add(Console.ReadLine());
                if (idade[i] >= 16 && (pais[i] == "brasileiro" || pais[i] == "brasileira"))
                {
                    contador++;
                }
                else
                {
                    cont++;
                }
            }
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("aluno {0}, idade {1}, nacionalidade {2}.", lista[x], idade[x], pais[x]);
            }
            Console.WriteLine("{0} sao os alunos que podem votar .", contador);
            Console.WriteLine("{0}sao os alunos que não podem votar.", cont);
        }
------------------------------------------------------------------------------------------ 
       public static void Desafio_037()
        {

            List<string> lista = listaDeNomes2();
            List<float> salario = new List<float>();
            List<double> rejust = new List<double>();
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.Write("Informe  o salário {0}: ", lista[i]);
                salario.Add(Convert.ToSingle(Console.ReadLine()));
                if (salario[i] <= 300)
                {
                    double reajuste = salario[i] * 0.5;
                    rejust.Add(salario[i] + reajuste);
                }
                else
                {
                    double reajuste = salario[i] * 0.3;
                    rejust.Add(salario[i] + reajuste);
                }
            }
            for (int x = 0; x < lista.Count(); x++)
            {
                Console.WriteLine("Funcionário {0}, Seu salario foi reajustado em {1} reais.", lista[x], rejust[x]);
            }
        }

------------------------------------------------------------------------------------------ 
        public static void Desafio_038()
        {
            for (int i = 1; i <= 100; i++)
            {
               if (i % 3 != 0)
               {
                    int min = 1;
                    int max = 100;
                    int soma = (min + max) * ((max - min + 1) / 2) - i;
                    Console.WriteLine(soma);
                    Console.WriteLine("-----------");
                    Console.WriteLine(i);                                           
                }                                           
            }           
        }
 ------------------------------------------------------------------------------------------ 
          static void Desafio_039()
        {
            for (int i = 1; i < 120; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.WriteLine(i + ",");
                }
            }
        }
 ------------------------------------------------------------------------------------------ 
  static void Desafio_040()
        {
            List<string> lista = listaDeNomes2();
            List<float> altura = new List<float>();
            List<double> matricula = new List<double>();
            double maior = 0;
            double menor = 0;
            double codmaior = 0;
            double codmenor = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite a altura do aluno {0}: ", lista[i]);
                altura.Add(Convert.ToSingle(Console.ReadLine()));
                Console.WriteLine("Informe o número da matrícula {0}: ", lista[i]);
                matricula.Add(1000 + i);
                if (i == 0)
                {
                    maior = altura[i];
                    menor = altura[i];
                    codmais = matricula[i];
                    codmeno = matricula[i];
                }
                else if (altura[i] > maior)
                {
                    maior = altura[i];
                    codmaior = matricula[i];
                }
                else if (altura[i] < menor)
                {
                    menor = altura[i];
                    codmenor = matricula[i];
                }
            }
                Console.WriteLine("O aluno mais baixo possui {0} de altura, múmero de matrícula = {1}", menor, codmenor);
                Console.WriteLine("O aluno mais alto possui {0} de altura, múmero de matrícula = {1}", maior, codmaior);
        }

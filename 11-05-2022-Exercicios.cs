 public static void Encontro24_Codigoo1()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numeros.Add(7);
            numeros.Add(8);
            numeros.Add(9);
            numeros.Add(10);

            for (int i = 0; i <= numeros.Count(); i++)

            {
                Console.WriteLine(i);
            }

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }

        public static void Desafio_011()
        {

            List<string> Listanomes = new List<string>();
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Quantidade de alunos na lista {0}", Listanomes.Count());
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
                Listanomes.Add(nome);
                Console.WriteLine("Deseja terminar (S/N)?");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Quantidade de alunos na lista {0}", Listanomes.Count());
                Console.WriteLine("Imprimindo a lista...");
                foreach (string item in Listanomes)
                {
                    Console.WriteLine("-->{0}", item);
                }
            }
        }

        public static void Desafio_012()
        {
            List<string> Listanomes = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Quantidade de alunos na lista {0}", Listanomes.Count());
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
                Listanomes.Add(nome);
                Console.WriteLine("Deseja terminar (S/N)?");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S")
                {
                    break;
                }
            }
            Console.Clear();
            Listanomes.Sort();
            Console.WriteLine("Quantidade de alunos na lista {0}", Listanomes.Count());
            Console.WriteLine("Imprimindo a lista...");
            foreach (string item in Listanomes)
            {
                Console.WriteLine("-->{0}", item);
            }
        }

        public static void Encontro24_Codigo02()
        {
            Random rand = new Random();
            rand.Next();
            rand.Next(100);
            rand.Next(1, 100);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Número gerado = {0}", rand.Next(100));

            }
        }


        public static List<string> CriarListaDeNomes()
        {
            List<string> listaDeNomes = new List<string>();
            listaDeNomes.Add("Matheus");
            listaDeNomes.Add("Lucas");
            listaDeNomes.Add("Julia");
            listaDeNomes.Add("Romeu");
            listaDeNomes.Add("Antonieta");
            listaDeNomes.Add("Pedro");
            listaDeNomes.Add("Tadeu");
            listaDeNomes.Add("Tomé");
            listaDeNomes.Add("Carlos");
            listaDeNomes.Add("Isabela");
            return listaDeNomes;
        }

        public static void Desafio_013()
        {
            List<string> lista = CriarListaDeNomes();
            Random rand = new Random();
            int indice = rand.Next(lista.Count());
            Console.WriteLine("Índice sorteado: {0}", indice);
            Console.WriteLine("O Escolhido será: {0}", lista[indice]);
        }


        public static void Desafio_014()
        {
            List<string> lista = CriarListaDeNomes();
            Console.WriteLine("Original");
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");                
            Random rand = new Random();
            List<string> listaEmbaralhada = lista.OrderBy(x => rand.Next()).ToList();
            Console.WriteLine("EMBARALHADA");
            foreach(string item in listaEmbaralhada)
            {
                Console.WriteLine(item);
            }                   
        }

        public static void Desafio_015()
        {
            List<string> lista = CriarListaDeNomes();
            Console.WriteLine("Original");
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            Random rand = new Random();
            List<string> listaEmbaralhada = lista.OrderBy(x => rand.Next()).ToList();
            int indice = rand.Next(listaEmbaralhada.Count());
            
            Console.WriteLine("EMBARALHADA");
            foreach (string item in listaEmbaralhada)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Índice sorteado: {0}", indice);
            Console.WriteLine("O Escolhido será: {0}", listaEmbaralhada[indice]);



        }

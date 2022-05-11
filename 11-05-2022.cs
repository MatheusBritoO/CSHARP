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

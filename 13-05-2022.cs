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
        public static void Desafio_039()
        {
            for (int i = 0; i <= 120; i++)
            {
               
                if (i / 3 != 0)  
                {
                Console.WriteLine(i);
                }
            }

        }

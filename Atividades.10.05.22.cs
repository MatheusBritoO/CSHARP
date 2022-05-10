public static void Desafio_006()
        {
            Console.Write("Informe a altura da parede: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a largura da parede: ");
            double largura  = Convert.ToDouble(Console.ReadLine());

            double area = largura * altura;
            double tinta = area / 2 ;

            Console.WriteLine("A sua parede tem a área de {0}m², você precisará de {1} litros de tinta.",area, tinta);

-------------------------------------------------------------------------------------------------------------------------------
        }

-------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_007()
        {
            Console.Write("Preço do produto: ");
            string preço = Console.ReadLine();
            double num = Convert.ToDouble(preço);
            double desconto = num - (num * 5 / 100);
            Console.WriteLine("O Valor do produto com desconto é de R${0}", desconto);         
        }
-------------------------------------------------------------------------------------------------------------------------------

        public static void Desafio_008()
        {
            Console.Write("Informe Salario: ");
            string salario = Console.ReadLine();
            double num = Convert.ToDouble(salario);
            double aumento = num + (num * 15 / 100);
            Console.WriteLine("O Valor do salario com aumento é de R${0}", aumento);
        }
-------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_009()
        {
            Console.Write("Informe os graus celsius a serem convertidos: ");
            string graus = Console.ReadLine();
            double celci = Convert.ToDouble(graus);
            double conver = (celci * 9) / 5 + 32;
            Console.WriteLine("O valor em farenheit é {0}.", conver);
        }
-------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_010()
        {
            Console.Write("Informe os KM percorridos pelo carro: ");
            string km = Console.ReadLine();
            double kil = Convert.ToDouble(km);

            Console.Write("Informe os dias alugados: ");
            string dias = Console.ReadLine();
            double dia = Convert.ToDouble(dias);
            double preço = 60 * dia + 0.15 * kil;
            Console.WriteLine("O valor a pagar é de {0}.", preço);
        }  
            

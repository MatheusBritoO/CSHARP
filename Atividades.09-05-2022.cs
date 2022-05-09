 public static void Desafio_003()
        {
            Console.WriteLine("Informe o numero de metros: ");
            string metros = Console.ReadLine();
            int num = Convert.ToInt32(metros);

            int cent = num * 100;
            int milim = num * 1000;

            Console.WriteLine("O valor em centimetros é {0} e o valor em milimetros é {1}", cent, milim);       
            }   
  ----------------------------------------------------------------------------------------------------------------------------------- 
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
  --------------------------------------------------------------------------------------------------------------------
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

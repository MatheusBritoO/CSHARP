  public static void Desafio_016()
        {
            Console.WriteLine("Informe um número: ");
            string numer = Console.ReadLine();
            int num = Convert.ToInt32(numer);

            if (num % 2 == 0)

            {
                Console.WriteLine("O numero {0} é par.", num);
            }
             else

             { 
                Console.WriteLine("O numero {0} é impar.", num);
             }
        }
-------------------------------------------------------------------------------------------------------------------------------------------    

 public static void Desafio_017()
        {
            Console.WriteLine("Informe seu nome: ");
            string Nome = Console.ReadLine();           
            Console.WriteLine("Informe seu sobrenome: ");
            string Sobrenome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Olá meu nome é: {0}",Nome + Sobrenome);          
            Console.WriteLine("Olá meu nome é: {0}",Nome.ToUpper() + Sobrenome.ToUpper());
            Console.WriteLine("Olá meu nome é: {0}",Nome.ToLower() + Sobrenome.ToLower());
            Console.WriteLine("O numero de letras do seu primeiro nome é: {0}",Nome.Count());
            {
            Console.WriteLine("Olá meu nome é: {0}", Nome.Count() + Sobrenome.Count());
            }         
        }
 
 -------------------------------------------------------------------------------------------------------------------------------------------
 public static void Desafio_018()
        {

            Console.WriteLine("Iforme sua operação com 1- Para Adição, 2- Para Subtração ,3-Para Divisão ou 4-Para Multiplic~ção : ");
            string oper = Console.ReadLine();
            int numoper = Convert.ToInt32(oper);
            
            Console.WriteLine("Informe o primeiro numero: ");
            string numer1 = Console.ReadLine();
            int num = Convert.ToInt32(numer1);

            Console.WriteLine("Informe o segundo número: ");
            string numer2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numer2);
              
            if (numoper == 1)
            {
                Console.WriteLine("Resultado: {0} ", num + num2);
            }
            if (numoper == 2)
            {
                Console.WriteLine("Resultado: {0} ", num - num2);
            }
            if (numoper == 3)
            {
                Console.WriteLine("Resultado: {0} ", num / num2);
            }
            if (numoper == 4)
            {
                Console.WriteLine("-->Resultado: {0} ", num * num2);
            }
--------------------------------------------------------------------------------------------------------------------------------------------------
  public static void Desafio_019()
        {           

            Console.WriteLine("Iforme sua idade : ");
            string idade = Console.ReadLine();
            int num = Convert.ToInt32(idade);
            if (num >= 18)
            {
                ConsoleColor Verde = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida{0}.", Verde);
            }
            if (num < 18)
            {
                ConsoleColor Vermelho = ConsoleColor.Red;
                Console.WriteLine("Permissão negada{0}.", Vermelho);
            }
        }
--------------------------------------------------------------------------------------------------------------------------------------------------        
       public static void Desafio_020()
        {
            Console.WriteLine("Escreva sua frase : ");
            string frase = Console.ReadLine();
            string result = frase.Replace("A", "&").Replace("a", "&");         
            Console.WriteLine(result);
        }
 

-------------------------------------------------------------------------------------------------------------------------------------------------- 
 public static void Desafio_021()
        {
            Console.WriteLine("Iforme seu salario: ");
            string sal = Console.ReadLine();
            int num = Convert.ToInt32(sal);

            if (num >1700)
            {
                Console.WriteLine("Novo salario de {0}.",num + 200);
            }
            if (num < 1700)
            {
                Console.WriteLine("Novo Salario de : {0}.",num +300  );
            }

        }
--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_022()
        {
            Console.WriteLine("Iforme sua altura: ");
            string altura = Console.ReadLine();
            double num = Convert.ToDouble(altura);

            Console.WriteLine("Iforme seu peso: ");
            string peso = Console.ReadLine();
            int num1 = Convert.ToInt32(peso);

            Console.WriteLine("Seu IMC é : {0}.", (num * num) / num1);

        }
--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_023()
        {
            Console.WriteLine("Iforme sua altura: ");
            string altura = Console.ReadLine();
            double num = Convert.ToDouble(altura);

            Console.WriteLine("Iforme sua largura: ");
            string largura = Console.ReadLine();
            double num1 = Convert.ToDouble(largura);

            Console.WriteLine("Iforme seu comprimento: ");
            string compr = Console.ReadLine();
            double num2 = Convert.ToDouble(compr);

            Console.WriteLine("Seu volume  é : {0}.",num * num1 * num2);
        }
--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_024()
        {
            Console.WriteLine("Iforme sua altura: ");
            string altura = Console.ReadLine();
            double num = Convert.ToDouble(altura);
            Console.WriteLine("Iforme seu raio: ");
            string raio = Console.ReadLine();
            double num1 = Convert.ToDouble(raio);       
            Console.WriteLine("Seu volume  é : {0}.", 3,14 * num * num1);
--------------------------------------------------------------------------------------------------------------------------------------------------
             public static void Desafio_025()
        {
            Console.WriteLine("Iforme A: ");
            string blabla = Console.ReadLine();
            double num = Convert.ToDouble(blabla);          
            Console.WriteLine("Iforme B: ");
            string haha = Console.ReadLine();
            double num1 = Convert.ToDouble(haha);
            double a;
            a = Math.Pow(num, 2);
            double b;
            b = Math.Pow(num1, 2);
            Console.WriteLine("Seu volume  é : {0}.", (num + num1) * 2 / a + 2 * a * b + b);
        }
--------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Desafio_026()
        {
            Console.WriteLine("Iforme seu raio: ");
            string raio = Console.ReadLine();
            double num1 = Convert.ToDouble(raio);
            double r;
            r = Math.Pow(num1, 3);
            Console.WriteLine("Seu volume  é : {0}.", 4/3 *3,14*r);      
       } 
----------------------------------------------------------------------------------------------------------------------
   public static void Desafio_027()
        {
            Console.WriteLine("Iforme o numero 1: ");
            string blabla = Console.ReadLine();
            double num = Convert.ToDouble(blabla);           
            Console.WriteLine("Iforme o numero 2: ");
            string haha = Console.ReadLine();
            double num1 = Convert.ToDouble(haha);
            Console.Clear();
            Console.WriteLine("Sua adição é : {0}.",num + num1 );
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sua subtração é : {0}.", num - num1);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sua multiplicação é : {0}.", num * num1);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sua divisão é : {0}.", num / num1);
        }
-----------------------------------------------------------------------------------------------------------------
public static void Desafio_028()
        {
            Console.WriteLine("Iforme a distancia percorrida em KM: ");
            string blabla = Console.ReadLine();
            double num = Convert.ToDouble(blabla);
            Console.WriteLine("Iforme os litros colocados antes da viagem: ");
            string haha = Console.ReadLine();
            double num1 = Convert.ToDouble(haha);
            Console.Clear();
            Console.WriteLine("litros consumidos: {0}.",num / num1);
        }
-----------------------------------------------------------------------------------------------------------------
 public static void Desafio_029()
        {
            Console.WriteLine("Iforme o valor da prestação: ");
            string blabla = Console.ReadLine();
            double num = Convert.ToDouble(blabla);
            Console.WriteLine("Iforme a taxa de juros: ");
            string haha = Console.ReadLine();
            double num1 = Convert.ToDouble(haha);
            Console.Clear();
            Console.WriteLine("Valor da prestação {0}.", num + (num * (num1 / 100)));
        }
------------------------------------------------------------------------------------------------------------------


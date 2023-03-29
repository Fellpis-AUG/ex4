using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            //int N = 1;

            //N = float.parse(Console.ReadLine())
            //como podemos ver acima não é possivel converter int em float ele apresenta um erro de converção, isso se deve pois o int é memos complexo que o float tendo menos caracteries assim sendo imposivel essa converção
            //--------------------------------------------------------
            //2

            //O Console.read() é usado para leitura de um charactere e retorna com o número decimal mas próximo 
            // e Console.ReadLine() é usado para fazer a leitura de linhas como no Console.ReadLine()
            //---------------------------------------------------------------
            //3
            //para não alterar os numeros das variaveis ou coromper os dados por isso usamos o Console.ReadLine()
            //-------------------------------------------------

            //4
            //int n1, n2, n3;
            //Console.WriteLine("entre com um numero:");
            //n1 = int.Parse(Console.ReadLine());
            //n2 = n1 / 2;
            //n3 = n1 % 2;
            //if (n3 == 0 && n2 * 2 > 10)
            //    Console.WriteLine("mensagem 1");
            //else
            //    Console.WriteLine("mensagem 1");
            //Console.ReadKey();

            //é´para verificar se um numero é divisilvel por 2 ou não se entrar com 8 a saida sera:a mensagem 1 mostrando que é divisivel se entrar com 27 sera:a mensagem 1 e com 28 sera:tambem a mensagem 1
            //------------------------------------------

            //5

            //double S, So, V, T;

            //Console.WriteLine("informe a posição inicial:");
            //So = double.Parse(Console.ReadLine());
            //Console.WriteLine("informe a velocidade constante:");
            //V = double.Parse(Console.ReadLine());
            //Console.WriteLine("informe o instante:");
            //T = double.Parse(Console.ReadLine());

            //S = So + (V * T);
            //Console.WriteLine("a posição final será" + S);
            //Console.ReadKey();

            //-----------------------------------------------------------

            //6
            //int N;

            //Console.WriteLine("digite um numero:");
            //N = int.Parse(Console.ReadLine());

            //if (N % 3 == 0 && N % 5 == 0 && N % 10 == 0)
            //{
            //    Console.WriteLine("ele é divisivel por 3, 5 e 10");
            //}
            //else if (N % 3 == 0 && N % 5 == 0)
            //{
            //    Console.WriteLine("ele é divisivel por 3 e 5 ");
            //}
            //else if (N % 3 == 0)
            //{
            //    Console.WriteLine("ele é divisivel por 3");
            //}
            //else if (N % 5 == 0)
            //{
            //    Console.WriteLine("ele é divisivel por 5");
            //}
            //else
            //{
            //    Console.WriteLine("ele não é divisivel por nenhuma das opções");

            //}
            //Console.ReadKey();

            //-----------------------------------------------------------------------------------------

            //7
            //double km;

            //Console.WriteLine("digite seu km");
            //km = double.Parse(Console.ReadLine());

            //if (km <= 100 && km >= 82) 
            //{
            //    Console.WriteLine("o aluno demorara 12 minutos");
            //}
            //else if (km < 82 && km >= 55)
            //{
            //    Console.WriteLine("o aluno vai demorar 27 minutos");
            //}
            //else if (km < 55 && km >= 29)
            //{
            //    Console.WriteLine("o aluno vai demorar 40 minutos");
            //}
            //else if (km < 29 && km >= 12)
            //{
            //    Console.WriteLine("o aluno vai demorar 57 minutos");
            //}
            //else if (km < 12 && km >= 0)
            //{
            //    Console.WriteLine("o aluno vai demorar 71 minutos");
            //}
            //else
            //{
            //    Console.WriteLine("o valor não é valido")
            //}
            //Console.ReadLine();
        }

    }
}

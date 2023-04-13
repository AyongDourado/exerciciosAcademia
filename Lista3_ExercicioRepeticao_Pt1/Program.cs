namespace Lista3_ExerciciosRepeticao_Pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.
            /*
            int n;
            int idade;
            int somaIdades = 0;
            int media;

            Console.WriteLine("Digite a quantidade de pessoas:");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Idade da " + n + "º pessoa:");
                idade = int.Parse(Console.ReadLine());
                somaIdades += idade;
            }
            
            media = somaIdades / n;

            Console.WriteLine("Média das idades: " + media);
            */


            // -----------------------------------------------------------------------------------------------------------------


            // 2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
            /*
            double num;
            double maior = 0;
            int posicao = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Digite o " + i + "º número");
                num = Convert.ToDouble(Console.ReadLine());

                if (i == 1)
                {
                    maior = num;
                    posicao = i;
                }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                        posicao = i;
                    }
                }
            }

            Console.WriteLine("O maior número é o " + posicao + "º : " + maior);*/


            // -----------------------------------------------------------------------------------------------------------------


            // 3 - Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.
            /*
            double x = 0;
            double multi;

            Console.WriteLine("Informe um número:");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                multi = x * i;
                Console.WriteLine(x + " x " + i + " = " + multi);
            }*/


            // -----------------------------------------------------------------------------------------------------------------


            // 4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
            /*
            double x;
            double y;
            double potencia = 0;

            Console.WriteLine("x:");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("y:");
            y = double.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {
                if ( i == 0 )
                {
                    potencia = x;
                }
                else
                {
                    potencia *= x;                   
                }               
            }

            Console.WriteLine("x^y = " + potencia);*/


            // -----------------------------------------------------------------------------------------------------------------


            // 5 - Escreva um algoritmo para calcular o fatorial de um número.
            /*
            int num;
            int fatorial;

            Console.WriteLine("Número para calcular o fatorial:");
            num = int.Parse(Console.ReadLine());

            fatorial = num;

            if (num == 0 )
            {
                Console.WriteLine("0! = 1");
            }
            else if (num == 1)
            {
                Console.WriteLine("1! = 1");
            }
            else if (num > 1)
            {
                for (int i = num-1; i >= 1; i--)
                {
                    fatorial *= i;
                }
                Console.WriteLine(num + "! = " + fatorial);
            }
            else
            {
                Console.WriteLine("Fatorial inválido.");
            }*/


            // -----------------------------------------------------------------------------------------------------------------


            /*
            6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
            aplicadas para aquela turma. Por fim,leia as notas das avaliações de cada aluno e mostre sua nota final
            (média das notas das avaliações).*/
            /*
            int numAlunos;
            int qtdAva;
            double nota;
            double media = 0;

            Console.WriteLine("Número de alunos:");
            numAlunos  = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de avaliações:");
            qtdAva = int.Parse(Console.ReadLine());

            for (int i = 0; i < numAlunos ; i++)
            {
                for (int j = 0; j < qtdAva ; j++)
                {
                    Console.WriteLine("Nota da " + (j+1) + "º avaliação do " + (i + 1) + "º aluno:");
                    nota = int.Parse(Console.ReadLine());

                    media += nota;
                }

                media = media / qtdAva;
                Console.WriteLine("A média do " + i + "º aluno é: " + media);
                media = 0;
            }*/


            // -----------------------------------------------------------------------------------------------------------------


            /*
            7 - Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
            um usuário. Apresente o resultado.*/
            /*
            int qtdPares = 0;
            int qtdImpares = 0;
            double num;

            for (int i = 0; i < 20; i++)
            {
                Console.Write((i+1) + "º número:");
                num = double.Parse(Console.ReadLine());
                
                else if (num % 2 == 0)
                {
                    qtdPares++;
                }
                else 
                { 
                    qtdImpares++;
                }
            }

            Console.WriteLine("Quantidade de números pares: " + qtdPares);
            Console.WriteLine("Quantidade de números pares: " + qtdImpares);
            */
            ;
        }
    }
}
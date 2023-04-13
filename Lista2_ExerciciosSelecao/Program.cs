namespace Lista2_exerciciosSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            Área do triangulo = (base * altura) / 2; 
            Teste se a base ou a altura digitada não foi igual a zero.
            */
            /*
            Console.WriteLine("Informe o valor da base do triângulo: ");
            double baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do triângulo: ");
            double altura = double.Parse(Console.ReadLine());

            if (baseT == 0 || altura == 0)
            {
                Console.WriteLine("Não foi possível calcular o a área. Base ou altura iguais a 0");
            }
            else
            {
                double area = (baseT * altura) / 2;
                Console.WriteLine("Área: " + area);
            } */



            // -------------------------------------------------------------------------------------------------



            /*2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. */
            /*
            double par;

            Console.WriteLine("Digite um número:");
            par = double.Parse(Console.ReadLine());

            if (par % 2 == 0 )
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("Não é par.");
            } 
            */



            // -------------------------------------------------------------------------------------------------



            //* 3) Escrever um algoritmo para ler quatro valores, calcular a sua média, e escrever na tela os que são superiores à média. */

            /*
            Console.WriteLine("Digite o primeiro valor: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            double q = Convert.ToDouble(Console.ReadLine());

            double media = (p + s + t + q) / 4;

            Console.WriteLine("A média é: " + media);

            if (p > media)
            {
                Console.WriteLine(p + " é superior à média ");
            }
            if (s > media)
            {
                Console.WriteLine(s + " é superior à média ");
            }
            if (t > media)
            {
                Console.WriteLine(t + " é superior à média ");
            }
            if (q > media)
            {
                Console.WriteLine(q + " é superior à média ");
            }
            */



            // -------------------------------------------------------------------------------------------------



            /* 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
             Mostrar na tela qual dos professores tem o maior salário total.*/

            /*
            Console.WriteLine("Quantidade de horas aula dada pelo professsor 1");
            double horas1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora recebido: ");
            double vlr1 = double.Parse(Console.ReadLine()); 

            double salario1 = horas1 * vlr1;

            Console.WriteLine("Quantidade de horas aula dada pelo professsor 2");
            double horas2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora recebido: ");
            double vlr2 = double.Parse(Console.ReadLine());

            double salario2 = horas2 * vlr2;

            if (salario1 > salario2)
            {
                Console.WriteLine("O professor 1 tem o salário maior");
            }
            else if (salario2 > salario1) 
            { 
                Console.WriteLine(" O professor 2 tem o salário maior."); 
            }
            else 
            { 
                Console.WriteLine("Os dois professores possuem salários iguais"); 
            }
            */


            // -------------------------------------------------------------------------------------------------


            /*
             5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
             se a média das duas notas for maior ou igual a 7,0. 
             Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
             é a média entre a nota do exame e a média das 2 notas. 
             Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
             escrever “Reprovado”.
             */
            /*
            Console.WriteLine("Digite a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());

            float media = (n1 + n2) / 2;

            if(media >= 7)
            {
                Console.WriteLine("Aprovado! :D");
            }
            else
            {
                Console.WriteLine("Digite a nota do exame: ");
                float exame = float.Parse(Console.ReadLine());
                float mediaF = (exame + media) / 2;
                if(mediaF >= 5)
                {
                    Console.WriteLine("Aprovado! :)");
                }
                else
                {
                    Console.WriteLine("Reprovado! :(");
                }   
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /*
             * 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
             * O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
             * O cálculo do imc = peso / (altura * altura)

             * IMC 
             * menor que 18                -> baixo peso
             * maior que 18 e menor que 25 -> peso normal
             * maior que 25 e menor que 30 -> sobrepeso
             * maior que 30 e menor que 35 -> obesidade
             * maior que 35                -> obesidade grau sério
            */
            /*
            Console.WriteLine("Nome em MAIÚSCULO: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Altura em metros: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Peso em Kg: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if(imc < 18)
            {
                Console.WriteLine(nome + ", você está abaixo do peso.");
            }
            else if(imc < 25)
            {
                Console.WriteLine(nome + ", você está com peso normal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine(nome + ", você está com sobrepeso.");
            }
            else if (imc < 35)
            {
                Console.WriteLine(nome + ", você está com obesidade.");
            }
            else
            {
                Console.WriteLine(nome + ", você está com obesidade grau sério.");
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /* 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
            exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.*/
            /*
            string palavra, frase;
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra: ");
            palavra = Console.ReadLine();

            Console.WriteLine(frase.Contains(palavra) ? "Contém" : "Não contém");
            */

            //OU

            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine("A palavra " +  palavra + " está dentro da frase " + frase);
            //}
            //else
            //{
            //    Console.WriteLine("Não possui a palavra")
            //}


            // -----------------------------------------------------------------------------------------------------


            /*
             8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
             Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
             Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
             E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
             total de vendas. 
             */
            /*
            Console.Write("Código do funcionário: ");
            int cod = int.Parse(Console.ReadLine());

            Console.Write("Nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Salário base do funcionário: R$");
            float salario = float.Parse(Console.ReadLine());

            Console.Write("Total de vendas do funcionário: R$");
            float vendas = float.Parse(Console.ReadLine());

            if (vendas > 5000)
            {

                float aumento = vendas * 10 / 100;                
                double novoSal = salario + aumento;
                Console.WriteLine("Salário base: R$" + salario);
                Console.WriteLine("Aumento de 10% - R$" + aumento);
                Console.WriteLine("Salário final: R$" + novoSal);              
            }
            else if (salario > 1000)
            {
                float aumento = vendas * 7 / 100;
                double novoSal = salario + aumento;
                Console.WriteLine("Salário base: R$" + salario);
                Console.WriteLine("Aumento de 7% - R$" + aumento);
                Console.WriteLine("Salário final: R$" + novoSal);
            }
            else if (vendas > 500)
            {
                float aumento = vendas * 5 / 100;
                float salFinal = salario + aumento;

                Console.WriteLine("Salário base: " + salario + "\nAumento de 5% do total de vendas - R$" + aumento + "\nSalário final: " + salFinal);
            }
            else
            {
                Console.WriteLine("Não recebe aumento.");
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
            Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
            Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
            menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
            150, avisá-lo que será necessário adicionar 2 unidades de insulina.
            */
            /*
            Console.WriteLine("Digite o valor de glicemia em jejum: ");
            float vlr1 = float.Parse(Console.ReadLine());

            if (vlr1 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            }
            if (vlr1 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }

            Console.WriteLine("Digite o valor de glicemia em jejum: ");
            float vlr2 = float.Parse(Console.ReadLine());

            if (vlr2 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            }
            if (vlr2 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }

            Console.WriteLine("Digite o valor de glicemia em jejum: ");
            float vlr3 = float.Parse(Console.ReadLine());

            if (vlr3 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            }
            if (vlr3 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }

            float media = (vlr1 + vlr2 + vlr3) / 3;
            if(media < 80)
            {
                Console.WriteLine("Necessário diminuir 2 doses de insulina.");
            }
            if (media > 150)
            {
                Console.WriteLine("Necessário adicionar 2 doses de insulina.");
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /*
             * 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
                O programa deve mostrar os dados do atleta mais novo e mais alto.
            */
            /*
            Console.Write("Atleta 1\nNome: ");
            string nome1 = Console.ReadLine();

            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double altura1 = double.Parse(Console.ReadLine());

            Console.Write("Atleta 2\nNome: ");
            string nome2 = Console.ReadLine();

            Console.Write("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double altura2 = double.Parse(Console.ReadLine());

            if (idade1 < idade2 &&  altura1 > altura2)
            {
                Console.WriteLine("O atleta 1 é mais alto e mais novo.");
                Console.WriteLine(nome1);
                Console.WriteLine(idade1 + " anos");
                Console.WriteLine(altura1);
            }
            else if (idade2 < idade1 && altura2 > altura1)
            {
                Console.WriteLine("O atleta 2 é mais alto e mais novo.");
                Console.WriteLine(nome2);
                Console.WriteLine(idade2 + " anos");
                Console.WriteLine(altura2);
            }
            else
            {
                Console.WriteLine("Nenhum é mais alto e mais novo");
            }*/


            // -----------------------------------------------------------------------------------------------------


            /* 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
            O programa deve exibir se a hora digitada está ou não válida. 
            Lembre que usaremos o padrão de hora com 24h, de 0 a 23.*/
            /*
            Console.WriteLine("Informe a hora:");
            string horaRecebida = Console.ReadLine();

            if (horaRecebida.Contains(':'))
            {
                string[] horaEminuto = horaRecebida.Split(':');

                string Hora = horaEminuto[0];

                string Minuto = horaEminuto[1];                

                try
                {
                    int hora = int.Parse(Hora);

                    int minuto = int.Parse(Minuto);

                    if ((hora >= 0 && hora <= 23) && (minuto >= 0 && minuto <= 59))
                    {
                        Console.WriteLine("Hora válida!");
                    }
                    else
                    {
                        Console.WriteLine("Hora inválida.");
                    }
                }                           
                catch (FormatException formexcp)
                {
                    Console.WriteLine(formexcp);
                }               

            }
            else
            {
                Console.WriteLine("Formatação inválida. Digite no formato HH:MM");
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /* 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
            R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
            armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
            No final do processamento, exibir o salário total e o salário excedente do operário.*/
            /*
            Console.WriteLine("Código:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas:");
            int numeroHoras = int.Parse(Console.ReadLine());

            int salario;

            int HRextra;
            int extra;

            if (numeroHoras > 50)
            {
                HRextra = (numeroHoras - 50);
                extra = HRextra * 20;
            }
            else
            {
                HRextra = 0;
                extra = 0;
            }

            salario = (numeroHoras - HRextra) * 10;

            int salarioTotal = salario + extra;

            Console.WriteLine("Salario total: " + salarioTotal + "\nSalário excedente: " + extra); */


            // -----------------------------------------------------------------------------------------------------


            /* 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            seu peso ideal, utilizando as seguintes fórmulas:
            Para homens: (72.7 * h) - 58
            Para mulheres: (62.1 * h) - 44.7*/
            /*
            Console.WriteLine("Digite a altura:");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número correspondente ao sexo da pessoa:\n1 - Homem\n2 - Mulher");
            int s = int.Parse(Console.ReadLine());

            double pesoIdeal;

            if (s == 1)
            {
                pesoIdeal = (72.7 * h) - 58;
                Console.WriteLine("Peso ideal: " + pesoIdeal);
            }
            else if (s == 2)
            {
                pesoIdeal = (62.1 * h) - 44.7;
                Console.WriteLine("Peso ideal: " + pesoIdeal);
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            */
            /*
            try
            {
                int s = int.Parse(Console.ReadLine());

                if (s == 1)
                {
                    pesoIdeal = (72.7 * h) - 58;
                }
                else if (s == 2)
                {
                    pesoIdeal = (62.1 * h) - 44.7;
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida.");
            }*/


            // -----------------------------------------------------------------------------------------------------


            /*
             14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
             link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).
             */
            /*
            Console.WriteLine("Tamanho do arquivo em MB para download:");
            double tamArqMB = double.Parse(Console.ReadLine());

            Console.WriteLine("Velocidade de um link de Internet em Mbps:");
            double velocidadeInternet = double.Parse(Console.ReadLine());

            double tempoDownload = (tamArqMB * 8 / velocidadeInternet) * 60;

            Console.WriteLine("Tempo aproximado de download do arquivo usando o link (em minutos): " + tempoDownload);
            */


            // -----------------------------------------------------------------------------------------------------


            /* 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
            e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
            Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/
            /*
            Console.WriteLine("Tamanho em metros quadrados da área a ser pintada:");
            double tamanhoArea = double.Parse(Console.ReadLine());

            double litrosTinta = tamanhoArea / 3;
            double latas = litrosTinta / 18;
            double precoTotal = latas * 80;

            int numLatas = (int)latas;

            double diferenca = latas - numLatas;

            if (diferenca != 0)
            {                
                numLatas++; 
                precoTotal = numLatas * 80;
                Console.WriteLine("\nQuantidade de latas a serem compradas (sobrando tinta): " + numLatas + "\nPreço total: R$" + precoTotal);
                Console.WriteLine("Sobra aproximadamente " + diferenca + " litros.");
            }
            else
            {
                Console.WriteLine("Quantidade de latas a serem compradas: " + latas + "\nPreço total: R$" + precoTotal);
            }
            */


            // -----------------------------------------------------------------------------------------------------



            /* 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
            enfrentar novamente em um novo jogo.
            ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/
            /*
            Console.WriteLine("Informe o placar do jogo.");
            Console.WriteLine("Número de gols do time da casa:");
            int Tcasa = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de gols do time de fora:");
            int Tfora = int.Parse(Console.ReadLine());

            if (Tfora - Tcasa >= 2)
            {
                Console.WriteLine("O time de fora já se classificou!");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
                Console.WriteLine("Informe o placar do novo jogo.");
                Console.WriteLine("Número de gols do time da casa:");
                Tcasa = int.Parse(Console.ReadLine());

                Console.WriteLine("Número de gols do time de fora:");
                Tfora = int.Parse(Console.ReadLine());

                if (Tcasa > Tfora)
                {
                    Console.WriteLine("O time da casa passou de fase!");
                }
                else if (Tcasa < Tfora)
                {
                    Console.WriteLine("O time de fora passou de fase!");
                }
                else 
                { 
                    Console.WriteLine("Desesmpate pendente."); 
                }
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /* 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
            os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).*/
            /*
            Console.WriteLine("Lado a: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lado b: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lado c: ");
            double n3 = double.Parse(Console.ReadLine());

            double soma1e2 = n1 + n2;
            double soma1e3 = n1 + n3;
            double soma2e3 = n2 + n3;

            if (n1 <= soma2e3 && n2 <= soma1e3 && n3 <= soma1e2) //menor ou igual??
            {
                Console.Write("Podem formar um triângulo");

                if (n1 == n2 && n1 == n3)
                {
                    Console.WriteLine(" equilátero.");
                }
                else if (n1 == n2 || n1 == n3 || n2 == n3)
                {
                    Console.WriteLine(" isósceles.");
                }
                else
                {
                    Console.WriteLine(" escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não podem formar um triângulo");
            }
            */


            // -----------------------------------------------------------------------------------------------------


            /* 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.*/
            /*
            Console.WriteLine("Primeiro valor:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro valor:");
            double n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O primeiro é o maior valor: " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O segundo é o maior valor: " + n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("O terceiro é o maior valor: " + n3);
            }
            else
            {
                Console.WriteLine("Não é possível determinar o maior valor.");
            }
            */

            // -----------------------------------------------------------------------------------------------------


            // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
            /*
            Console.WriteLine("Primeiro valor:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro valor:");
            double n3 = double.Parse(Console.ReadLine());

            // Ordenar em ordem crescente
            //double[] num = { n1, n2, n3 };    
            //Array.Sort(num);                      // ERA PRA USAR IF
            //foreach (int i in num)
            //{
            //    Console.WriteLine("\nValores ordenados:" + i);
            //}

            if(n1>n2 && n1>n3)
            {
                if(n2<n3)
                {
                    cw
                }
                cw("n1 
            }
            else if(n2>n1 && n2>n3)
            {
                cw(
            }
            else if(n3>n1 && n3>n2)
            {
                cw(
            }

            */

            // -----------------------------------------------------------------------------------------------------


            /* 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            plus: você pode gerar o número de forma randomica(função random c#).*/
            /*
            int secreto = 8;

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Tente adivinhar o número secreto. Você tem " + i + " tentativas");
                double tentativa = double.Parse(Console.ReadLine());

                if (tentativa > 8)
                {
                    Console.WriteLine("O número secreto é menor.");
                }
                else if (tentativa < 8)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("Acertou!");
                }
            }           
            */


            // -----------------------------------------------------------------------------------------------------


            /* 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada(metros, centímetros, polegadas ou pés) e uma unidade de
            medida de saída usando um menu com o comando switch case.O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
            valor para a unidade de saída selecionada.*/
            /*
            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Centímetros");
            Console.WriteLine("3. Polegadas");
            Console.WriteLine("4. Pés");
            int entrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a unidade de medida de saída:");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Centímetros");
            Console.WriteLine("3. Polegadas");
            Console.WriteLine("4. Pés");
            int saida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de entrada:");
            double valor = double.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1: //metros
                    switch (saida)
                    {
                        case 1: //metros
                            Console.WriteLine(valor);
                            break;
                        case 2: //centímetros
                            Console.WriteLine(valor * 100);
                            break;
                        case 3: //polegadas
                            Console.WriteLine(valor * 39.37);
                            break;
                        case 4: //pés
                            Console.WriteLine(valor * 3.281);
                            break;
                    }
                    break;

                case 2: //centímetros
                    switch (saida)
                    {
                        case 1: //metros
                            Console.WriteLine(valor / 100);
                            break;
                        case 2: //centímetros
                            Console.WriteLine(valor);
                            break;
                        case 3: //polegadas
                            Console.WriteLine(valor * 0.3937);
                            break;
                        case 4: //pés
                            Console.WriteLine(valor * 0.03281);
                            break;
                    }
                    break;
                case 3: //polegadas
                    switch (saida)
                    {
                        case 1: //metros
                            Console.WriteLine(valor / 39.37);
                            break;
                        case 2: //centímetros
                            Console.WriteLine(valor / 0.3937);
                            break;
                        case 3: //polegadas
                            Console.WriteLine(valor);
                            break;
                        case 4: //pés
                            Console.WriteLine(valor / 12); // divide por 0.08333
                            break;
                    }
                    break;
                case 4: //pés
                    switch (saida)
                    {
                        case 1: //metros
                            Console.WriteLine(valor / 3.281);
                            break;
                        case 2: //centímetros
                            Console.WriteLine(valor / 0.03281);
                            break;
                        case 3: //polegadas
                            Console.WriteLine(valor * 12);
                            break;
                        case 4: //pés
                            Console.WriteLine(valor);
                            break;
                    }
                    break;
            }*/
        }
    }
}
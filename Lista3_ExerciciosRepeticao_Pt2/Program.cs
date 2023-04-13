namespace TerceiraListaRepeticao_Pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
            (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            Exemplo:
            Digite um número inteiro positivo: -8
            Valor incorreto!
            Digite um número inteiro positivo: 8
            Numero digitado: 8
            Números inteiros pares entre 1 e 8: 2, 4, 6.*/

            /*
            int x = 0;

            for (; x <= 0;)
            {
                Console.WriteLine("Informe um valor positivo:");
                x = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
            informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
            Exemplo:
            Digite um número inteiro positivo: 8
            Numero digitado: 8
            Números inteiros pares entre 1 e 8: 2, 4, 6.
 
            Deseja informar outro número (s/n)? S
 
            Digite um número inteiro positivo: 12
            Numero digitado: 20
            Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
            Deseja informar outro número (s/n)? N */


            // Opção 1:

            /* bool outro = true;

            while (outro)
            {
                int x = 0;

                while (x <= 0)
                {
                    Console.WriteLine("Informe um valor positivo:");
                    x = int.Parse(Console.ReadLine());
                }

                int soma = 0;
                int contagem = 0;
 
                for (int i = 1; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                        contagem++;
                        soma += i; // soma = soma + i;
                    }
                }

                Console.WriteLine("Deseja informar outr número s/n");
                string resposta = Console.ReadLine();
 
                if(resposta == "s")
                {
                    outro = true;
                }
                else
                {
                    outro = false;
                }
            }*/


            // Opção 2:

            /* while (true)
            {
                int x = 0;

                while (x <= 0)
                {
                    Console.WriteLine("Informe um valor positivo:");
                    x = int.Parse(Console.ReadLine());
                }

                int soma = 0;
                int contagem = 0;

                for (int i = 1; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                        contagem++;
                        soma += i; // soma = soma + i;
                    }
                }

                Console.WriteLine("Deseja informar outr número s/n");
                string resposta = Console.ReadLine();

                if(resposta == "n")
                {
                    break;
                }
            } */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
            Se o usuário digitar 0 o programa em VS deve parar. 
            Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. */

            //recomendado while no 3, 4 e 6. 13 melhor com for.

            /*
            int numero;           

            while (true)
            {
                Console.WriteLine("Digite um número ou 0 para parar.");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }
                else if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é par.");

                    if (numero == 2)
                    {
                        Console.WriteLine(numero + " é primo.");
                    }
                }
                else
                {
                    Console.WriteLine(numero + " é um número ímpar.");

                    int divisores = 0;

                    for (int i = 1; i <= numero; i++)
                    {                      
                        if (numero % i == 0)
                        {
                            divisores++;
                        }                                             
                    }
                    if (divisores == 2)
                    {
                        Console.WriteLine(numero + " é um número primo.");
                    }
                }                               
            }*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
            Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
            Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
            Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
            escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
            de votos em branco. */
            /*
            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;

            while (true)
            {
                Console.WriteLine("Digite o voto (JOAO, ZECA ou BRANCO) ou FIM para encerrar o programa:");
                string voto = Console.ReadLine();

                if (voto == "JOAO")
                {
                    votosJoao++;
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                }
                else if (voto == "FIM")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }

            }
            Console.WriteLine("Votos para JOAO: " + votosJoao);
            Console.WriteLine("Votos para ZECA: " + votosZeca);
            Console.WriteLine("Votos em branco: " + votosBranco);*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 5. Modifique o programa em VS anterior para aceitar votos nulos 
            (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
            Ao final, informe o nome do candidato vencedor, o número de votos nulos 
            e o número de pessoas que votaram.*/
            /*
            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int nulos = 0;
            int totalVotos = 0;


            while (true)
            {
                Console.WriteLine("Digite o voto (JOAO, ZECA ou BRANCO) ou FIM para encerrar o programa:");
                string voto = Console.ReadLine();
                totalVotos++;

                if (voto == "JOAO")
                {
                    votosJoao++;
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                }
                else if (voto == "FIM")
                {
                    break;
                }
                else
                {
                    nulos++;                   
                }                           
            }

            if (votosJoao > votosZeca)
            {
                Console.WriteLine("Candidato vencedor: JOAO!");
            }
            else if (votosZeca > votosJoao)
            {
                Console.WriteLine("Candidato vencedor: ZECA!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
            Console.WriteLine("Votos nulos: " + nulos);
            Console.WriteLine("Total de votos: " + totalVotos); */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
            Ao final, mostre a idade digitada.*/
            /*
            int idade;
            bool validacao;

            do
            {
                
                Console.WriteLine("Informe a idade:");
                validacao = int.TryParse(Console.ReadLine(), out idade);
                
                if (!validacao || idade <= 0)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números positivos.");
                }

            }
            while (idade <= 0);

            Console.WriteLine("Idade digitada: " +  idade); */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
            A cada solicitação, teste se o usuário informou um valor válido. 
            Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            informe que ele está incorreto e saia do programa em VS. 
            Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
            informe que está errada e saia. Se estiver correta, solicite o salário. 
            Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
            Se estiver correto, mostre todos os valores lidos.*/
            /*
            string nome;
            int idade;
            double salario;

            while (true)
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _))  //int.TryParse(nome, out _) verifica se a conversão de nome para inteiro é bem-sucedida, mas não armazena o valor convertido em nenhuma variável.
                {
                    Console.WriteLine("Nome incorreto. O programa será encerrado.");
                    break;
                }

                // Pedir a idade
                Console.Write("Digite sua idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Idade incorreta. O programa será encerrado.");
                    break;
                }

                // Pedir o salário
                Console.Write("Digite seu salário: ");
                if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
                {
                    Console.WriteLine("Salário incorreto. O programa será encerrado.");
                    break;
                }


                // Mostrar os valores lidos
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Salário: R$" + salario);

                break;
            }*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 8. Faça um programa em VS que solicite um numero inteiro. Se o 
            numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
            Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.*/
            /*
            int num;
            bool validacao;
            string repetir;

            for(; ; )
            {
                Console.WriteLine("Informe um número inteiro:");
                validacao = int.TryParse(Console.ReadLine(), out num);

                if (!validacao)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números positivos.");
                }
                else
                {
                    if (num % 2  == 0)
                    {
                        Console.WriteLine(num + " é par.");
                    }
                    else
                    {
                        Console.WriteLine(num + " é ímpar.");
                    }
                }

                Console.WriteLine("Deseja repetir o programa? ");
                repetir = Console.ReadLine();

                if (repetir != "SIM" || repetir != "Sim" || repetir != "sim")
                {
                    break;
                }
                
            }
            */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
            o zoológico num determinado dia, imprimindo:
            Quantas pessoas tem entre 1 e 3 filhos.
            Quantas pessoas tem entre 4 e 7 filhos.
            Quantas pessoas tem mais de 8 filhos.
            Quantas pessoas não tem filhos.*/
            /*
            int umEtres = 0;
            int quatroEsete = 0;
            int maisDeOito = 0;
            int nenhum = 0;
            int qtdFilhos;     
            
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("Quantidade de filhos da " + (i+1) + "º pessoa.");
                qtdFilhos = int.Parse(Console.ReadLine());

                if (qtdFilhos == 0)
                {
                    nenhum++;
                }
                else if (qtdFilhos >= 1 && qtdFilhos <= 3)
                {
                    umEtres++;
                }
                else if (qtdFilhos >= 4 && qtdFilhos <= 7)
                {
                    quatroEsete++;
                }
                else if (qtdFilhos >= 8)
                {
                    maisDeOito++;
                }

            }*/

            /* validacao = int.TryParse(Console.ReadLine(), out idade);
                
                if (!validacao || idade <= 0)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números positivos.");
                }*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /* 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
            Número de pessoas do sexo masculino.
            Número de pessoas do sexo feminino.
            Número de pessoas com idade inferior a 30 anos.
            Número de pessoas com idade superior a 60 anos.
            Média de idade das mulheres.*/
            /*
            string nome;
            int idadeMulher = 0;
            int idade;
            char sexo;
            int masculino = 0;
            int feminino = 0;
            int inferiorTrinta = 0;
            int superiorSessenta = 0;
            int mediaMulheres;
            int qtdMulheres = 0;
            

            for (int i = 0; i < 49; i++)
            {
                Console.WriteLine("Nome da " + (i+1) + "º pessoa");
                nome = Console.ReadLine();

                Console.WriteLine("Sexo da " + (i + 1) + "º pessoa (F ou M)");
                sexo = char.Parse(Console.ReadLine());

                if (sexo == 'F')
                {
                    feminino++;
                    qtdMulheres++;

                    Console.WriteLine("Idade da " + (i + 1) + "º pessoa:");
                    idadeMulher = int.Parse(Console.ReadLine());

                    if (idadeMulher < 30)
                    {
                        inferiorTrinta++;
                    }
                    else if (idadeMulher > 60)
                    {
                        superiorSessenta++;
                    }

                }
                else if (sexo == 'S')
                {
                    masculino++;

                    Console.WriteLine("Idade da " + (i + 1) + "º pessoa:");
                    idade = int.Parse(Console.ReadLine());

                    if (idade < 30)
                    {
                        inferiorTrinta++;
                    }
                    else if (idade > 60)
                    {
                        superiorSessenta++;
                    }
                }

                
            }

            Console.WriteLine("Número de pessoas do sexo masculino: " + masculino);
            Console.WriteLine("Número de pessoas do sexo feminino: " + feminino);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + inferiorTrinta);
            Console.WriteLine(" Número de pessoas com idade superior a 60 anos: " + superiorSessenta);

            if (qtdMulheres != 0)
            {
                mediaMulheres = idadeMulher / qtdMulheres;
                Console.WriteLine("Média de idade das mulheres: " + mediaMulheres);
            }*/



            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
            a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.*/
            /*
            double nota;
            double notaMaisAlta = 0;
            double notaMaisBaixa = 0;
            int qtdAlunos = 0;
            double mediaTurma;
            double somaNotas = 0;

            for (int i = 0; true; i++)
            {
                Console.WriteLine("Digite -1 para encerrar.");
                Console.WriteLine("Nota:");
                nota = double.Parse(Console.ReadLine());

                if (nota == -1)
                {
                    break;
                }
                if (i == 0)
                {
                    notaMaisAlta = nota;
                    notaMaisBaixa = nota;
                }
                else if (nota > notaMaisAlta)
                {
                    notaMaisAlta = nota;
                }
                else if (nota < notaMaisBaixa)
                {
                    notaMaisBaixa = nota;
                }

                somaNotas += nota;
                qtdAlunos++;
            }

            mediaTurma = somaNotas / (double)qtdAlunos;

            Console.WriteLine("Nota mais alta: " + notaMaisAlta);
            Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
            Console.WriteLine("Média aritmética da turma: " + mediaTurma);
            Console.WriteLine("Quantidade de alunos: " + qtdAlunos); */



            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*12. Apresentar o total da soma dos cem primeiros números inteiros.*/
            /*
            int soma = 0;

            for (int i = 0; i < 100; i++)
            {
                soma += i;
            }

            Console.WriteLine("Resultado da soma: " + soma);*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*13. Elaborar um programa que apresente o somatório dos valores pares existentes 
            entre 1 e 500.*/
            /*
            int somaPares = 0;
            
            for (i = 1; i<=500; i++)
            {
                if (i % 2 == 0)
                {
                    somaPares += i;
                }
            }
            Console.WriteLine("Resultado: " + somaPares); */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*14. Mostrar as potências de 2 variando de 0 a 10.*/
            /*
            int potencia = 1;
            for (int i = 0; i <= 10; i++)
            {
                //Console.WriteLine("2^{0} = {1}", i, potencia);
                Console.WriteLine("2^" + i + " = " + potencia);
                potencia *= 2;
            }
            */


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
            ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
            Considerar nota 7,0 como mínima para aprovação.*/
            /*
            double n1; 
            double n2;
            double n3;
            double n4;
            double media;

            Console.WriteLine("Informe a primeira nota:");
            n1 = double.Parse(Console.ReadLine());

            n1 *= 2;

            Console.WriteLine("Informe a segunda nota:");
            n2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Informe a terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            n3 *= 2;

            Console.WriteLine("Informe a quarta nota:");
            n4 = double.Parse(Console.ReadLine());

            n4 *= 4;

            media = (n1 + n2 + n3 + n4) / 9;

            if (media < 7)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Aprovado!");
            }*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
            multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
            (N*3; N*3*3; N*3*3*3; etc).*/
            /*
            double n;
            double resultado = 0;

            Console.WriteLine("Numero menor ou igual a 50:");
            n = double.Parse(Console.ReadLine());

            if (n > 50 )
            {
                Console.WriteLine("Valor inválido!");
            }
            else
            {
                while (n * 3 < 250 && n != 0)
                {
                    n *= 3;
                    resultado = n;
                    Console.WriteLine("Resultado: " + n);
                }
            }*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*17. Apresentar os quadrados dos números inteiros de 15 a 200.*/
            /*
            int quadrado;

            for (int i = 15; i <= 200; i++){

                quadrado = i * i;
                Console.WriteLine("O quadrado de " + i + " é: " + quadrado);
            }*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
            elevada a um expoente qualquer, ou seja, NM.*/
            /*
            double baseQqr;
            double expoente;

            Console.WriteLine("Base:");
            baseQqr = double.Parse(Console.ReadLine());

            double resultado = baseQqr;

            Console.WriteLine("Expoente:");
            expoente = double.Parse(Console.ReadLine());

            for (int i  = 1; i < expoente; i++)
            {
                if (expoente == 0)
                {
                    Console.WriteLine("Resultado: 1");
                }
                else
                { 
                    resultado = resultado * baseQqr; 
                }
            }
            Console.WriteLine("Resultado: " + resultado);*/


            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
            coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

            a) média do salário da população;
            b) média do número de filhos;
            c) maior salário;
            d) percentual de pessoas com salário até R$ 100,00.
            O final da leitura de dados se dará com a entrada de um salário negativo.*/
            /*
            double salario;
            int numFilhos;
            double mediaFilhos;
            double mediaSalarios;
            double maiorSalario = -1;
            double salarioAteCem = 0;
            int qtdHabitantes = 0;
            double somaSalarios = 0;
            int somaFilhos = 0;

            while (true)
            {
                Console.WriteLine("Digite um valor negativo em salário para finalizar.");
                Console.WriteLine("Salário:");
                salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                {
                    break;
                }

                if (salario <= 100)
                {
                    salarioAteCem++;
                }
                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
                somaSalarios += salario;


                Console.WriteLine("Número de filhos:");
                numFilhos = int.Parse(Console.ReadLine());

                somaFilhos += numFilhos;


                qtdHabitantes++;
            }
        
            mediaSalarios = somaSalarios / (double) qtdHabitantes;
            mediaFilhos = somaFilhos / (double) qtdHabitantes;
            salarioAteCem = salarioAteCem / (double) qtdHabitantes * 100;

            Console.WriteLine("Média do salário da população: " + mediaSalarios);
            Console.WriteLine("Média do número de filhos: " + mediaFilhos);

            if (maiorSalario != -1)
            {
                Console.WriteLine("Maior salário: " + maiorSalario);
            }

            Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: " + salarioAteCem + "%");*/



            // --------------------------- // --------------------------- // --------------------------- // --------------------------- //


            /*20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
            certa região, a qual coletou os seguintes dados referentes a cada habitante para 
            serem analisados:
            - sexo (masculino e feminino)
            - cor dos olhos (azuis, verdes ou castanhos)
            - cor dos cabelos (louros, castanhos, pretos)
            - idade 

            Faça um algoritmo que determine e escreva: 

            - a maior idade dos habitantes
            - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            e que tenham olhos verdes e cabelos louros.
            O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.*/
            /*
            int idade;
            int maiorIdade = -1;           
            char sexo;
            string corOlhos;
            string corCabelo;
            int qtdMulher = 0;

            while (true)
            {
                
                Console.WriteLine("Digite '-1' em idade para encerrar");
                Console.WriteLine("Idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade == -1)
                {
                    break;
                }

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }

                Console.WriteLine("Sexo (F ou M):");
                sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Cor dos olhos (azuis, verdes ou castanhos):");
                corOlhos = Console.ReadLine();

                Console.WriteLine("Cor dos cabelos (louros, castanhos ou pretos):");
                corCabelo = Console.ReadLine();

                if (idade >= 18 && idade <= 35 && sexo == 'F' && (corOlhos == "verdes" || corOlhos == "Verdes" || corOlhos == "VERDES") && (corCabelo == "louros" || corCabelo == "Louros" || corCabelo == "LOUROS"))
                {
                    qtdMulher++;                  
                }
            }
            Console.WriteLine("A maior idade é: " + maiorIdade);
            Console.WriteLine("Quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros: " + qtdMulher);*/
        }
    }
}
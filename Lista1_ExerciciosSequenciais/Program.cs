using System.Net;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace RespostasAtv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            /* Console.WriteLine("Digite o primeiro valor: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double s = Convert.ToDouble(Console.ReadLine());

            double media = (p + s) / 2;

            Console.WriteLine("A média é: " + media); */


            // ------------------------------------------------------------------------------------------


            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            /* Console.WriteLine("Digite o primeiro valor: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            double q = Convert.ToDouble(Console.ReadLine());

            double media = (p + s + t + q) / 4;

            Console.WriteLine("A média é: " + media);*/


            // ------------------------------------------------------------------------------------------


            // 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

            /* Console.WriteLine("Digite o valor de a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a: " + a + "\nb: " + b);

            double aux = a;
            a = b;
            b = aux;

            Console.WriteLine("novo a: " + a + "\nnovo b: " + b);*/


            // ------------------------------------------------------------------------------------------


            /* 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.*/

            /* Console.WriteLine("Digite o dia: ");
            string dia = (Console.ReadLine());

            Console.WriteLine("Digite os dois números do mês: ");
            string mes = (Console.ReadLine());

            Console.WriteLine("Digite os 4 digitos do ano desejado: ");
            string ano = Console.ReadLine();

            Console.WriteLine("AAAAMMDD: " + ano + mes + dia);
            Console.WriteLine("AAMMDD: " );
            Console.WriteLine("AAMMDD: " + ano.Substring(ano.Length - 2) + mes + dia);*/


            // ------------------------------------------------------------------------------------------


            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //   (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
            //   consumido para percorrê-la (medido em l).

            /* Console.WriteLine("Digite a distância percorrida em Km: ");
            double km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de combustivel consimuda para este percurso em litros: ");
            double litros = Convert.ToDouble(Console.ReadLine());

            double consumoMedio = km / litros;

            Console.WriteLine("Consumo médio: " + consumoMedio + " Km/l.");*/


            // ------------------------------------------------------------------------------------------


            //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            //de IPI (única) a ser acrescentada. 

            /* Console.WriteLine("Digite a quantidade de peças do parafuso A: ");
            int qtdA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário do parafuso A: ");
            double vlrA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de peças do parafuso B: ");
            int qtdB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário do parafuso B: ");
            double vlrB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a somente o número da porcentagem de IPI a ser acrescentada: ");
            double ipi = double.Parse(Console.ReadLine());

            Console.WriteLine("Parafuso A:\n Quantidade: " + qtdA + "\n Valor unitário: " + vlrA + "\n IPI: " + ipi + "%");
            Console.WriteLine("Parafuso B:\n Quantidade: " + qtdB + "\n Valor unitário: " + vlrB + "\n IPI: " + ipi + "%");*/


            // ------------------------------------------------------------------------------------------


            //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

            /* Console.WriteLine("Número do vendedor: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário fixo: ");
            double salFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Total de vendas efetuadas: ");
            int vendas = int.Parse(Console.ReadLine());

            Console.WriteLine("Percentual recebido pelo total de vendas: ");
            double percent = double.Parse(Console.ReadLine());

            // Cálculo do salário total do vendedor
            double total = salFixo + vendas * percent;

            Console.WriteLine("Vendedor " + num + "\n Salário: " + total);*/


            // ------------------------------------------------------------------------------------------


            //8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F = (9 * C + 160) / 5.

            /* Console.WriteLine("Digite a temperatura em ºC: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = (9 * c + 160) / 5;
            // ou double f = c * 1.8 + 32;

            Console.WriteLine("A temperatura em ºF é " + f);*/


            // ------------------------------------------------------------------------------------------


            //9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //conseqüente pagamento dos boletos das duas prestações.

            /* Console.WriteLine("Informe o valor da mercadoria: ");
            double vlr = double.Parse(Console.ReadLine());

            double div = vlr / 3;

            int prestacao = (int)div;

            double entrada = (div - prestacao) * 3 + prestacao;

            Console.WriteLine("Entrada: " + entrada + ", prestação 1: " + prestacao + ", prestação 2: " + prestacao); */


            // ------------------------------------------------------------------------------------------


            /* 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            notas de menor valor fossem distribuídas em número mínimo possível. 
            Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
            Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”.*/

            /*
            Console.WriteLine("Valor do saque: ");
            double vlr = Double.Parse(Console.ReadLine());

            int qtdNtsCem = 0;
            int qtdNtsCinq = 0;
            int qtdNtsVinte = 0;
            int qtdNtsDez = 0;
            int qtdNtsCinco = 0;
            int qtdntsUm = 0;
            
            while (vlr >= 100)
            {
                vlr -= 100;
                qtdNtsCem++;
            }

            if (qtdNtsCem != 0)
            {
                Console.WriteLine(qtdNtsCem + " notas de 100 reais.");
            }

            while (vlr >= 50)
            {
                vlr -= 50;
                qtdNtsCinq++;
            }

            if (qtdNtsCinq != 0)
            {
                Console.WriteLine(qtdNtsCinq + " notas de 50 reais.");
            }

            while (vlr >= 20)
            {
                vlr -= 20;
                qtdNtsVinte++;
            }

            if (qtdNtsVinte != 0)
            {
                Console.WriteLine(qtdNtsVinte + " notas de 20 reais.");
            }

            while (vlr >= 10)
            {
                vlr -= 10;
                qtdNtsDez++;

            }

            if (qtdNtsDez != 0)
            {
                Console.WriteLine(qtdNtsDez + " notas de 10 reais.");
            }

            while (vlr >= 5) 
            {
                vlr -= 5;
                qtdNtsCinco++;
            }

            if (qtdNtsCinco != 0)
            {
                Console.WriteLine(qtdNtsCinco + " notas de 5 reais.");
            }

            while (vlr >= 1)
            {
                vlr -= 1;
                qtdntsUm++;
            }

            if (qtdntsUm != 0)
            {
                Console.WriteLine(qtdntsUm + " notas de 1 real.");
            }
            */


            //--------------------------------------------------------------------------------


            /* 11) Escreva um algoritmo para ler o número de eleitores de um município, 
            o número de votos brancos, nulos e válidos. 
            Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.*/
            /*
            Console.WriteLine("Informe o número de eleitores do município: ");
            int eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos brancos: ");
            int brancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos nulos: ");
            int nulos = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Número de votos válidos: ");
            int validos = int.Parse(Console.ReadLine());

            brancos = brancos * 100 / eleitores;
            nulos = nulos * 100 / eleitores;
            validos = validos * 100 / eleitores;

            Console.WriteLine("Brancos: " + brancos + "%");
            Console.WriteLine("Nulos: " + nulos + "%");
            Console.WriteLine("Válidos: " +  validos + "%"); */


            // ------------------------------------------------------------------------------------------------------


            /* 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
            marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
            dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.

            Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
            
            Média do consumo = Total quilometragem / quantidade de combustível gasto

            Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90) */

            /*
            Console.WriteLine("Marcação do odômetro no início do dia: ");
            double kmInicio = double.Parse(Console.ReadLine());

            Console.WriteLine("Marcação do odômetro no final do dia: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de litros de combustúvel gasto: ");
            double combustivel = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor total(R$) recebido dos passageiros ");
            double valorRec = double.Parse(Console.ReadLine());

            double KmPercorrido = kmFinal - kmInicio;

            double mediaConsumo = KmPercorrido / combustivel;
            
            double lucro = valorRec - (combustivel * 6.90);

            Console.WriteLine("Média do comsumo: " + mediaConsumo + "Km/l.");
            Console.WriteLine("Lucro líquido do dia: R$" + lucro);
            */


            // ---------------------------------------------------------------------------------------------------


            /* 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            vendidas pelo vendedor, calcule e mostre: o salário do empregado. */

            /*
            Console.WriteLine("Valor do salário mínimo: ");
            double salarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Preço de custo de cada bicicleta: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de bicicletas vendidas pelo vendedor: ");
            int qtdBiciVendidas = int.Parse(Console.ReadLine());

            double salEmpreg = salarioMin * 2 + (preco * 15 / 100) * qtdBiciVendidas;

            Console.WriteLine("Salário do empregado: R$" + salEmpreg);
            */
        }
    }
}
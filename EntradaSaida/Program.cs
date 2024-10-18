using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaMateria, notaAtual = 0 , somaNotas = 0, mediaFinal;
            string materia1, materia2, materia3, materia4;
            int qtdMaterias;
            string nome;
            int mediaNecessaria;

            Console.WriteLine("** Calculadora de Média Escolar **");
            Console.WriteLine(" ");
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Qual a quantidade de matérias que deseja usar para o cálculo? ");
            qtdMaterias = int.Parse(Console.ReadLine());
            Console.Write("Qual a média necessária para a sua aprovação? ");
            mediaNecessaria = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Digite as suas notas do semestre abaixo, " + nome + ":");
            Console.WriteLine("------------------------------------------");


            for (int i = 0; i < qtdMaterias; i++)
            {
                Console.Write("Digite a nota" + (i + 1) + ": ");
                notaMateria = double.Parse(Console.ReadLine());
                notaAtual = somaNotas += notaMateria;
            }
            Console.WriteLine(" ");
            mediaFinal = notaAtual / qtdMaterias;

            Console.WriteLine("Somatória das notas: " + notaAtual);

            if (mediaFinal < mediaNecessaria) 
            { 
                Console.WriteLine("Sua média final foi: " + mediaFinal);
                Console.WriteLine(" ");
                Console.WriteLine("Sinto muito, " + nome + ", você não foi aprovado. \nFaltaram " + (mediaNecessaria - mediaFinal) + " pontos." );
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Sua média final foi: " + mediaFinal + ".");
                Console.WriteLine(" ");
                Console.WriteLine("Parabéns, " + nome + ", você foi aprovado!");
                Console.WriteLine(" ");
            }
        }
    }
}


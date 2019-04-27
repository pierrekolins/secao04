using System;
using System.Globalization;

namespace Secao04Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seção 04 - Introdução à Programação Orientada a Objetos");
            Console.WriteLine("Exercícios");
            int choose = 0;
            Console.Write("Escolha exercício (1 - 2): ");
            choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Exercicio01();
            }
            else {
                Exercicio02();
            }
        }

        static void Exercicio01() {
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();
            Console.Write("Digite um nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite um nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {
                Console.WriteLine("Maior idade " + a.nome);
            }
            else {
                Console.WriteLine("Maior idade " + b.nome);
            }

        }

        static void Exercicio02() {
            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();

            Console.Write("Digite o nome do funcionario 1: ");
            a.name = Console.ReadLine();
            Console.Write("Digite o salário: ");
            a.salary = double.Parse(Console.ReadLine());

            Console.Write("Digite o nome do funcionario 2: ");
            b.name = Console.ReadLine();
            Console.Write("Digite o salário: ");
            b.salary = double.Parse(Console.ReadLine());

            double mediaSalary = (a.salary + b.salary) / 2;

            Console.WriteLine("Média de salário: "+ mediaSalary, CultureInfo.InvariantCulture);
        }
    }
}

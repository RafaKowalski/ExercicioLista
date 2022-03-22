using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, name, salario));
                Console.WriteLine();
            }

            Console.Write("entre com o id do usuário que deseja aumentar o salario: ");
            int encontrarId = int.Parse(Console.ReadLine());

            Funcionario funcionario = list.Find(x => x.ID == encontrarId);
            if (funcionario != null)
            {
                Console.Write("entre com a porcentagem que deseja aumentar: ");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionario.AumentoSalario(porcentagem);
            }
            else
                Console.WriteLine("este ID não existe");

            Console.WriteLine();
            Console.WriteLine("lista atualizada dos funcionários: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
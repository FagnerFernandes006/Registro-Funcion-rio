using System.Collections.Generic;
using System.Globalization;

namespace RegistroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários você irá registrar? ");
            int qtd = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < qtd; i++)
            {
                int posicao = i + 1;
                Console.WriteLine("Funcionário #" + posicao + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Funcionario() { Id = id, Nome = nome, Salario = salario });   
            }

            Console.Write("Entre com o Id do funcionário que terá o salário aumentado: ");
            int search = int.Parse(Console.ReadLine());
            Funcionario s1 = list.Find(x => x.Id == search);

            if (s1 == null)
            {
                Console.WriteLine("Este Id não existe!");
                Console.WriteLine();
                Console.WriteLine("Lista: ");
            }   
            else
            {
                Console.WriteLine("Você escolheu: " + s1.Nome);
                Console.Write("Porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s1.AumentaSalario(porcentagem);
                Console.WriteLine();
                Console.WriteLine("Lista atualizada: ");
            }
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
using System;

namespace Teste_Faisp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Pessoal, boa noite!");

            var cliente = new Cliente();
            var contaBancaria = new ContaBancaria();

            cliente.Id = 1;
            cliente.Nome = "José";
            cliente.DataNascimento = "15/08/1965";

            contaBancaria.Banco = "NuBank";
            contaBancaria.Numero = "05236-10";

            Console.WriteLine($"Olá, {cliente.Nome}, sua data de nascimento é {cliente.DataNascimento}");
            Console.WriteLine($"{cliente.Nome}, você tem uma conta no Banco {contaBancaria.Banco}, de número {contaBancaria.Numero}");
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
    }

    public class ContaBancaria
    {
        public string Banco { get; set; }
        public string Numero { get; set; }
    }
}
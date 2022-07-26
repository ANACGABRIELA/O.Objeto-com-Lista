using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio
{
    
   
    public class Pessoa
    {
        static Pessoa EncontrarPessoaPeloCPF(string cpf, List<Pessoa> pessoas)
    {
        Pessoa resultado = pessoas.SingleOrDefault(x => x.CPF == cpf);
        return resultado;
    }
    
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string DataNascimento { get; set; }
        public string Naturalidade { get; set; }


        // para gerar construtor "CTRL + ."\\
        public Pessoa(string nome, string cpf, string rg, string telefone, string endereco, string dataNascimento, string naturalidade)
        {
            Nome = nome;
            CPF = cpf;
            Rg = rg;
            Telefone = telefone;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Naturalidade = naturalidade;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Qual opção?");
            Console.WriteLine("1 - Cadastrar pessoa");
            Console.WriteLine("2 - Listar pessoas");
            Console.WriteLine("0 - Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != (int)0)
            {
                if (opcao == 1)
                {
                    Console.WriteLine("Qual o nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Qual o CPF");
                    string CPF = Console.ReadLine();
                    Console.WriteLine("Qual o rg");
                    string rg = Console.ReadLine();
                    Console.WriteLine("Qual o Telefone");
                    string Telefone = Console.ReadLine();
                    Console.WriteLine("Qual o Endereço");
                    string Endereco = Console.ReadLine();
                    Console.WriteLine("Qual a data de nascimento");
                    string DataNascimento = Console.ReadLine();
                    Console.WriteLine("Qual a naturalidade");
                    string naturalidade = Console.ReadLine();

                    Pessoa pessoa = new Pessoa(nome, CPF, rg, Telefone, Endereco, DataNascimento, naturalidade);
                    pessoas.Add(pessoa);
                    Console.WriteLine("Pessoa registrada com sucesso.");
                }

                else if (opcao == 2)
                {
                    foreach (Pessoa p in pessoas)
                    {
                        Console.WriteLine("nome" + p.Nome);
                        Console.WriteLine("CPF" + p.CPF);
                        Console.WriteLine(" rg" + p.Rg);
                        Console.WriteLine(" Telefone" + p.Telefone);
                        Console.WriteLine(" Endereço" + p.Endereco);
                        Console.WriteLine(" data de nascimento" + p.DataNascimento);
                        Console.WriteLine(" naturalidade" + p.Naturalidade);
                    }



                }


                Console.WriteLine("Qual opção?");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listar pessoas");
                Console.WriteLine("3 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());


            }
        }
    }
}
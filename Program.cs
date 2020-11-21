using System;

namespace Exercicio_de_validacao_de_nome_idade_salario_e_estado_civil_18_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valdação de dados");
            Console.WriteLine("-----------------");

            Console.Write("Digite o nome de usuário: ");
            string nome = Console.ReadLine();

            while(nome == ""){
                Console.WriteLine("O nome não pode ser vazio");
                Console.WriteLine("Digite o nome de usuário");
                nome = Console.ReadLine();
            }

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            while(idade < 0 || idade > 150)
            {
                Console.WriteLine("A idade deve ser entre 0 a 150");
                Console.Write("Digite sua idade novamente: ");
                idade = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite seu salário: ");
            float salario = float.Parse(Console.ReadLine());

            while(salario <=0)
            {
                Console.WriteLine("O salário deve ser maior que zero");
                Console.Write("Digite seu salário: ");
                salario = float.Parse(Console.ReadLine());
            }

            bool validacao = true;
            do
            {
                Console.WriteLine("          Estado civil          ");
                Console.WriteLine("Selecione uma das opçôes abaixo: ");
                Console.WriteLine("[S] - Solteiro(a)");
                Console.WriteLine("[C] - Casado(a)");
                Console.WriteLine("[V] - Viúvo(a)");
                Console.WriteLine("[D] - Divorciado(a)");
                Console.Write("Opção desejada: ");
                string opcao = Console.ReadLine();

                switch(opcao.ToLower())
                {
                    case "s":
                        Console.WriteLine("Você selecionou solteiro(a)");
                        validacao = true;
                    break;

                    case "c":
                        Console.WriteLine("Você selecionou casado(a)");
                        validacao = true;
                    break;

                    case "v":
                        Console.WriteLine("Você selecionou viúvo(a)");
                        validacao = true;
                    break;

                    case "d":
                        Console.WriteLine("Você selecionou divorciado(a)");
                        validacao = true;
                    break;
                    default:
                        Console.WriteLine("Opção inválida");
                    break;

                }

            }while (validacao == false);

            Console.WriteLine("Estado civil cadastrado");
        }
    }
}

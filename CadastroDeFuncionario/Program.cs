namespace CadastroDeFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool deveContinuar = true;
            IList<Funcionario> funcionarios = new List<Funcionario>();

            while (deveContinuar)
            {
                Console.WriteLine("Cadastro de Funcionario");
                Console.WriteLine("Escolha uma opcao para seguir");
                Console.WriteLine("1 - Cadastrar funcionario\n2 - Listar funcionarios\n0 - Sair");

                string opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    // cadastrar
                    Console.WriteLine("Agora escolha o tipo de funcionario");
                    Console.WriteLine("1 - CLT\n2 - Estagiario\n3 - Terceirizado");

                    string opcaoTipoFuncionario = Console.ReadLine();
                    if (opcaoTipoFuncionario == "1")
                    {
                        Console.WriteLine($"Digite o CPF do funcionario CLT");
                        string cpfFuncionarioClt = Console.ReadLine();

                        Console.WriteLine("Digite o nome do funcionario CLT");
                        string nomeFuncionarioClt = Console.ReadLine();

                        Console.WriteLine("Por ultimo, digite o salario base do funcionario CLT");
                        string salarioBaseFuncionarioClt = Console.ReadLine();

                        double salarioBase = 0;
                        try
                        {
                            salarioBase = double.Parse(salarioBaseFuncionarioClt);
                        } catch (Exception ex)
                        {
                            Console.WriteLine("Valor de salario invalido");
                            continue;
                        }

                        FuncionarioClt funcionarioClt = new FuncionarioClt
                        {
                            Cpf = cpfFuncionarioClt,
                            Nome = nomeFuncionarioClt,
                            SalarioBase = salarioBase,
                            Tipo = "Clt"
                        };

                        funcionarios.Add(funcionarioClt);
                        Console.WriteLine("Funcionario CLT cadastrado com sucesso.");
                    }
                    else if (opcaoTipoFuncionario == "2")
                    {
                        Console.WriteLine($"Digite o CPF do funcionario Estagiario");
                        string cpfFuncionarioEstagiario = Console.ReadLine();

                        Console.WriteLine("Digite o nome do funcionario Estagiario");
                        string nomeFuncionarioEstagiario = Console.ReadLine();

                        Console.WriteLine("Digite o valor do bolsa auxilio do funcionario Estagiario");
                        string bolsaAuxilioFuncionarioEstagiario = Console.ReadLine();

                        double bolsaAuxilio = 0;
                        try
                        {
                            bolsaAuxilio = double.Parse(bolsaAuxilioFuncionarioEstagiario);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Bolsa auxilio invalida");
                            continue;
                        }

                        Console.WriteLine("Digite o valor do vale transporte do funcionario Estagiario");
                        string valeTransporteFuncionarioEstagiario = Console.ReadLine();

                        double valeTransporte = 0;
                        try
                        {
                            valeTransporte = double.Parse(valeTransporteFuncionarioEstagiario);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Vale transporte invalido");
                            continue;
                        }

                        FuncionarioEstagiario funcionarioEstagiario = new FuncionarioEstagiario
                        {
                            Cpf = cpfFuncionarioEstagiario,
                            Nome = nomeFuncionarioEstagiario,
                            BolsaAuxilio = bolsaAuxilio,
                            ValeTransporte = valeTransporte,
                            Tipo = "Estagiario"
                        };

                        funcionarios.Add(funcionarioEstagiario);
                        Console.WriteLine("Funcionario estagiario cadastrado com sucesso");
                    }

                }
                else if (opcaoMenu == "2")
                {
                    // listar funcionarios
                    Console.WriteLine("---- Listagem funcionarios ----");
                    foreach (Funcionario funcionario in funcionarios)
                    {
                        funcionario.ExibirDados();
                    }
                } else if (opcaoMenu == "0")
                {
                    deveContinuar = false;
                } 
                else
                {
                    Console.WriteLine("Opcao invalida");
                }
            }
        }
    }
}

using System;

namespace ProjetoElevador
{
    static class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            char andar;
            int quantidade;

            // MENSAGEM INICIAL

            Console.WriteLine(@"Olá! Bem-vindo(a) ao Edifício Mafalda!
            Nosso prédio possui 6 andares e o elevador tem capacidade máxima para 7 pessoas.
            Selecione a opção desejada:
                                      1 - Entrar no elevador
                                      2 - Permanecer no térreo
                          ");


            resposta = Console.ReadLine();

            if (resposta == "1")

            //QUANTIDADE DE PASSAGEIROS

            {
                Console.WriteLine("Quantas pessoas vão embarcar?");
                quantidade = int.Parse(Console.ReadLine());

                do
                {
                    if (quantidade <= 7)

                //MOVIMENTAÇÃO DE ANDAR
                    {
                        Console.WriteLine("Escolha o andar desejado:");
                        Console.WriteLine(@"
                            1 - Consultórios
                            2 - Escritórios
                            3 - Cinema
                            4 - Praça de Alimentação
                            T - Térreo
                            G - Garagem
                            ");

                        andar = Char.Parse(Console.ReadLine());

                        switch (andar)
                        {
                            case '1': Console.WriteLine("Você chegou ao 1º andar - Consultórios"); break;
                            case '2': Console.WriteLine("Você chegou ao 2º andar - Escritórios"); break;
                            case '3': Console.WriteLine("Você chegou ao 3º andar - Cinema"); break;
                            case '4': Console.WriteLine("Você chegou ao 4º andar - Praça de Alimentação"); break;
                            case 'T': Console.WriteLine("Você chegou ao Térreo"); break;
                            case 'G': Console.WriteLine("Você chegou na Garagem"); break;
                            default: Console.WriteLine("Opção inválida"); break;
                        }
                    }

                    else if (quantidade > 7)
                    {
                        Console.WriteLine("Limite excedido.");
                        Console.WriteLine("Nossa capacidade máxima é de 7 pessoas.");
                        Console.WriteLine("Aguarde o próximo elevador"); break;
                    }

                    else
                    {
                        Console.WriteLine("Opção inválida");

                    }

                    { }

                    Console.WriteLine("Deseja sair do elevador? Selecione a opção desejada:" +
                        "             1 - Sim" +
                        "             2 - Não");
                    resposta = Console.ReadLine();
                }

                while (resposta != "1");
                {
                    Console.WriteLine("Você saiu do elevador");
                }
            }
            else if (resposta == "2")
            {

                Console.WriteLine("Você permanece neste andar");
                Console.WriteLine("Deseja entrar no elevador? Digite S para Sim ou N para Não");
                resposta = Console.ReadLine();

                if (resposta == "S")
                {
                    do
                    {


                        Console.WriteLine("Quantas pessoas vão embarcar? Lembre-se que a capacidade máxima é de 7 pessoas.");
                        quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 7)
                        {
                            Console.WriteLine("Escolha um andar");
                            Console.WriteLine(@"
                            1 - Consultórios
                            2 - Escritórios
                            3 - Cinema
                            4 - Praça de Alimentação
                            T - Térreo
                            G - Garagem
                            ");

                            andar = Char.Parse(Console.ReadLine());

                            switch (andar)
                            {
                                case '1': Console.WriteLine("Você chegou ao 1º andar - Consultórios"); break;
                                case '2': Console.WriteLine("Você chegou ao 2º andar - Escritórios"); break;
                                case '3': Console.WriteLine("Você chegou ao 3º andar - Cinema"); break;
                                case '4': Console.WriteLine("Você chegou ao 4º andar - Praça de Alimentação"); break;
                                case 'T': Console.WriteLine("Você chegou ao Térreo"); break;
                                case 'G': Console.WriteLine("Você chegou na Garagem"); break;
                                default: Console.WriteLine("Opção inválida"); break;
                            }

                        }
                        else if (quantidade > 7)
                        {
                            Console.WriteLine("Limite excedido.");
                            Console.WriteLine("Nossa capacidade máxima é de 7 pessoas.");
                            Console.WriteLine("Aguarde o próximo elevador"); break;
                        }

                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }

                        Console.WriteLine("Deseja sair do elevador? Digite S para Sim ou N para Não");
                        resposta = Console.ReadLine();

                    } while (resposta != "S");
                    {
                        Console.WriteLine("Você saiu do elevador.");
                    }

                }
                else if (resposta == "N")
                {
                    Console.WriteLine("Você saiu do elevador.");
                }
                else
                {
                    Console.WriteLine("Opção indisponível");
                }
            }
            Console.ReadLine();
        }
    }
}
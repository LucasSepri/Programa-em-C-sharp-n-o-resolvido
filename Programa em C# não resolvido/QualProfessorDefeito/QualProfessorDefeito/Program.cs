using System;
using System.Threading;

namespace QualProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogar = true;

            while (jogar == true) 
            {
                string titulo = "JOGO ADIVINHE O PROFESSOR"; // AS LINHAS 14 ATÉ 21 CORRESPONDEM A TELA INICIAL DO JOGO
                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) +titulo));
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                string tecla = "TECLE ENTER PARA CONTINUAR";
                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (tecla.Length / 2)) +tecla));

                if (Console.ReadKey().Key == ConsoleKey.Enter) // CASO O JOGADOR TECLE ENTER O JOGO CONTINUARÁ
                {
                    Console.Clear(); // AS LINHAS 25 ATÉ 35 EXIBEM AS REGRAS E AVISOS DO JOGO E EM SEGUIDA CONTAM 5 SEGUNDOS PARA ENTÃO INICIAR O JOGO APRESENTANDO A PRIMEIRA PERGUNTA
                    Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) +titulo));
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    string regra = "AS REGRAS DO JOGO SÃO SIMPLES, PENSE EM UM PROFESSOR E O PROGRAMA ADIVINHARÁ QUAL PROFESSOR VOCÊ PENSOU";
                    Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (regra.Length / 2)) +regra));
                    string aviso = "DENTRO DE 5 SEGUNDOS O JOGO COMEÇARÁ COM A PRIMEIRA PERGUNTA!";
                    Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (aviso.Length / 2)) +aviso));
                    Thread.Sleep(5000);

                    Console.Clear(); // AS LINHAS 37 ATÉ 43 CORRESPONDEM A PRIMEIRA PERGUNTA
                    Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) +titulo));
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    string pergunta = "O PROFESSOR QUE VOCÊ PENSOU TEM ALGUM APELIDO? (s = sim, n = não)";
                    Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) +pergunta));

                    if (Console.ReadKey().Key != ConsoleKey.S) // COMPARADOR PARA VERIFICAR SE A TECLA "S" FOI PRESSIONADA
                    {
                        Console.Clear(); // AS LINHAS 48 ATÉ 55 CORRESPONDEM A SEGUNDA PERGUNTA CASO A PRIMEIRA PERGUNTA TENHA TIDO UMA RESPOSTA POSITIVA
                        Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) +titulo));
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        pergunta = "O PROFESSOR QUE VOCÊ PENSOU TEM ALGUM APELIDO NUMÉRICO? (s = sim, n = não)";
                        Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) +pergunta));

                        if (Console.ReadKey().Key == ConsoleKey.S) // COMPARADOR PARA VERIFICAR SE A TECLA "S" FOI PRESSIONADA
                        {
                            Console.Clear(); // AS LINHAS 59 ATÉ 66 CORRESPONDEM A TERCEIRA PERGUNTA (CASO A SEGUNDA TENHA TIDO UMA RESPOSTA POSITIVA)
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) +titulo));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            pergunta = "O PROFESSOR QUE VOCÊ PENSOU É BARRIGUDO E CALVO? (s = sim, n = não)";
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) +pergunta));

                            if (Console.ReadKey().Key != ConsoleKey.S) // COMPARADOR PARA VERIFICAR SE A TECLA "S" FOI PRESSIONADA
                            {
                                Console.Clear(); // AS LINHAS 70 ATÉ 80 CORRESPONDEM AO PROGRAMA ADIVINHANDO O PROFESSOR ESCOLHIDO
                                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + titulo));
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                string resposta = "VOCÊ PENSOU NO PROFESSOR 120";
                                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (resposta.Length / 2)) +resposta));
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");

                                pergunta = "VOCÊ DESEJA JOGAR DE NOVO? (s = sim, n = não)"; // O PROGRAMA PERGUNTA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) + pergunta));

                                if (Console.ReadKey().Key == ConsoleKey.S) // VERIFICA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                                {
                                    jogar = true;
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }
                            else if (Console.ReadKey().Key != ConsoleKey.N) // COMPARADOR PARA VERIFICAR SE A TECLA "N" FOI PRESSIONADA
                            {
                                Console.Clear(); // AS LINHAS 70 ATÉ 80 CORRESPONDEM AO PROGRAMA ADIVINHANDO O PROFESSOR ESCOLHIDO
                                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) +  titulo));
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                string resposta = "VOCÊ PENSOU NO PROFESSOR PAULINHO 90";
                                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (resposta.Length / 2)) +  resposta));
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");

                                pergunta = "VOCÊ DESEJA JOGAR DE NOVO? (s = sim, n = não)"; // O PROGRAMA PERGUNTA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                                Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) + pergunta));

                                if (Console.ReadKey().Key == ConsoleKey.S) // VERIFICA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                                {
                                    jogar = true;
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }
                        else if (Console.ReadKey().Key != ConsoleKey.N) // COMPARADOR PARA VERIFICAR SE A TECLA "N" FOI PRESSIONADA
                        {
                            Console.Clear(); // AS LINHAS 98 ATÉ 109 CORRESPONDEM AO PROGRAMA ADIVINHANDO O PROFESSOR ESCOLHIDO
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + titulo));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            string resposta = "VOCÊ PENSOU NO PROFESSOR BANANINHA";
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (resposta.Length / 2)) +resposta));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            pergunta = "VOCÊ DESEJA JOGAR DE NOVO? (s = sim, n = não)"; // O PROGRAMA PERGUNTA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) + pergunta));

                            if (Console.ReadKey().Key != ConsoleKey.S) // VERIFICA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                            {
                                jogar = true;
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.N) // COMPARADOR PARA VERIFICAR SE A TECLA "N" FOI PRESSIONADA
                    {
                        Console.Clear(); // AS LINHAS 100 ATÉ 107 CORRESPONDEM A SEGUNDA PERGUNTA CASO A RESPOSTA DA PRIMEIRA TENHA SIDO NEGATIVA
                        Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + titulo));
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        pergunta = "O PROFESSOR QUE VOCÊ PENSOU É MAGRO? (s = sim, n = não)";
                        Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) + pergunta));

                        if (Console.ReadKey().Key != ConsoleKey.S) // COMPARADOR PARA VERIFICAR SE A TECLA "S" FOI PRESSIONADA
                        {
                            Console.Clear(); // AS LINHAS 111 ATÉ 122 CORRESPONDEM AO PROGRAMA ADIVINHANDO O PROFESSOR ESCOLHIDO
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + titulo));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            string resposta = "VOCÊ PENSOU NO PROFESSOR OSWALDO";
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (resposta.Length / 2)) +resposta));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            pergunta = "VOCÊ DESEJA JOGAR DE NOVO? (s = sim, n = não)"; // O PROGRAMA PERGUNTA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) + pergunta));

                            if (Console.ReadKey().Key != ConsoleKey.S) // VERIFICA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                            {
                                jogar = true;
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.N) // COMPARADOR PARA VERIFICAR SE A TECLA "N" FOI PRESSIONADA
                        {
                            Console.Clear(); // AS LINHAS 138 ATÉ 149 CORRESPONDEM AO PROGRAMA ADIVINHANDO O PROFESSOR ESCOLHIDO
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + titulo));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            string resposta = "VOCÊ PENSOU NO PROFESSOR EDSON";
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (titulo.Length / 2)) + titulo));
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            pergunta = "VOCÊ DESEJA JOGAR DE NOVO? (s = sim, n = não)"; // O PROGRAMA PERGUNTA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                            Console.WriteLine(String.Format("{0}" + ((Console.WindowWidth / 2) + (pergunta.Length / 2)) + pergunta));

                            if (Console.ReadKey().Key == ConsoleKey.S) // VERIFICA SE O JOGADOR DESEJA JOGAR NOVAMENTE
                            {
                                jogar = false;
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }
                    }


                }


            }

            Console.ReadKey();
        }
    }
}

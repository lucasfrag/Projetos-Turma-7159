using System;

namespace C__Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada e saída
            Console.WriteLine("Bem-vindo ao sistema de notas");
          
           
            Console.WriteLine("Digite uma opção para continuar:");
            Console.WriteLine("1 - Cadastro de notas de alunos");
            Console.WriteLine("2 - Calcular idade");
            Console.WriteLine("0 - Sair");
            
            int resposta = int.Parse(Console.ReadLine());

            switch(resposta) {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Digite o nome do aluno:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a nota do aluno:");
                    double nota = Double.Parse(Console.ReadLine());

                    if(nota == 0) {
                        Console.WriteLine("Nota zerada!");
                    } else {
                        // Verificar se o aluno tirou uma nota maior que a média            
                        if( nota >= 6 ) {
                            Console.WriteLine("PASSOU!");
                        } else if(nota == 10 && nota <= 10) {
                            Console.WriteLine("GABARITOU!");
                        } else if(nota < 6 && nota >=0) {
                            Console.WriteLine("REPROVOU!");
                        } else {
                            Console.WriteLine("Nem passou e nem rodou.");
                        }
                    }

                    Console.WriteLine("A nota do aluno " + nome + " foi " + nota);
                    break;
                   
                case 2: 
                    Console.WriteLine("Digite seu ano de nascimento:");
                    int ano = int.Parse(Console.ReadLine());
                    
                    string anoAtual = System.DateTime.Now.ToString("yyyy");
                    int idade = int.Parse(anoAtual) - ano;




                    Console.WriteLine("O ano atual é " + anoAtual + " e a idade é " + idade);
                    break;
                
            }

           /*
            if(nota == 0) {
                Console.WriteLine("Valor inválido!");
            } else {
                // Verificar se o aluno tirou uma nota maior que a média            
                if( nota >= 6 ) {
                    Console.WriteLine("PASSOU!");
                } else if(nota == 10 && nota <= 10) {
                    Console.WriteLine("GABARITOU!");
                } else if(nota < 6 && nota >=0) {
                    Console.WriteLine("REPROVOU!");
                } else {
                    Console.WriteLine("Nem passou e nem rodou.");
                }
            }
            */


        }
    }
}

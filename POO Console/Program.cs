using System;

namespace POO_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exemplo com DO WHILE
            string resposta;
            ListaCarro lista = new ListaCarro();

            do {
                Carro outroCarro = new Carro();
                outroCarro.Cadastrar();
                //outroCarro.Exibir(); 

                // Argumento => passo algo || resposta
                lista.Adicionar(outroCarro);
                lista.Listar();
                
                Console.WriteLine("Você quer cadastrar outro carro? (S/N)");
                resposta = Console.ReadLine();  

                if(resposta == "N") {
                    lista.Calcular();
                }
            } while (resposta != "N");

            /* Exemplo com o WHILE


            string resposta = "Sim";
            while(resposta == "Sim" || resposta == "S" || resposta == "sim") {
                Carro outroCarro = new Carro();
                outroCarro.Cadastrar();
                outroCarro.Exibir(); 

                Console.WriteLine("Você quer cadastrar outro carro? (S/N)");
                resposta = Console.ReadLine();  
            }*/



            /* EXEMPLO DE REPETIÇÃO COM FOR

            Console.WriteLine("Quantos carros você quer cadastrar?");
            int reposta = int.Parse(Console.ReadLine());   
            for(int i = 0; i < reposta; i++) {
                Carro outroCarro = new Carro();
                outroCarro.Cadastrar();
                outroCarro.Exibir();
            }
            */

        }
    }
}

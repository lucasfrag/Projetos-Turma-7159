using System;

namespace POO_Console
{
    public class Carro
    {
        // Atributos - Caracteristicas de um carro
        public string marca;
        public int ano;
        public string cor;
        public double valor;

        // Métodos
        public void Exibir() 
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Valor: " + valor);
        }

        public void Cadastrar()
        {
            Console.WriteLine("Digite a marca do carro: ");
            marca = Console.ReadLine();
            
            Console.WriteLine("Digite o ano do carro: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a cor do carro: ");
            cor = Console.ReadLine();

            Console.WriteLine("Digite o valor do carro: ");
            valor = double.Parse(Console.ReadLine());

        }
        
    }
}
using System.Collections.Generic;
using System;

namespace POO_Console
{
    public class ListaCarro
    {
        // Atributo
        List<Carro> listaDeCarros = new List<Carro>();

        // Método
        // Parâmetro => exige algo || pede algo || pré-requisito
        public void Adicionar(Carro carroNovo) {
            listaDeCarros.Add(carroNovo);
        }

        public void Listar() {
            Console.WriteLine("CARROS CADASTRADOS:");
            Console.WriteLine("");

            for(int i=0; i < listaDeCarros.Count; i++) {
                Console.WriteLine("Marca: " + listaDeCarros[i].marca);
                Console.WriteLine("Ano: " + listaDeCarros[i].ano);
                Console.WriteLine("Cor: " + listaDeCarros[i].cor);
                Console.WriteLine("Valor: " + listaDeCarros[i].valor);  
                Console.WriteLine("");
            }          
        }

        public void Calcular() {
            double total = 0;

            for(int i=0; i < listaDeCarros.Count; i++) {
                total = listaDeCarros[i].valor + total;
            } 

            Console.WriteLine("O total é: R$" + total);
        }
 
    }
}
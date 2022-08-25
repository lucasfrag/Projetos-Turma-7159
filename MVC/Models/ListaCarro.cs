using System.Collections.Generic;

namespace MVC.Models
{
    public class ListaCarro
    {
        List<Carro> listaDeCarros = new List<Carro>();

        public List<Carro> Listar() {
            return listaDeCarros;
        }

        public void Adicionar(Carro carroNovo) {
            listaDeCarros.Add(carroNovo);
        }

        public double Calcular() {
            double total = 0;

            for(int i=0; i < listaDeCarros.Count; i++) {
                total = listaDeCarros[i].valor + total;
            } 

            return total;
        }        
    }
}
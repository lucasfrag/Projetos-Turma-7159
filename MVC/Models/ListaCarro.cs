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
    }
}
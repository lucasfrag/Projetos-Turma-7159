/****
Classes estáticas não precisam ser instanciadas.
No ASP.NET Core MVC, classes estáticas vivem do início 
ao fim da execução do programa.
Por isso, Dados deve ser usado para manipular as informações
dos pedidos.
Exemplos de uso:
Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
Dados.PedidoAtual.MetodoDePedido();
*****/
namespace MVC.Models 
{
    public static class Dados {
        public static ListaCarro ListaCarroAtual { get; set;}
        static Dados()
        {
            ListaCarroAtual = new ListaCarro();
        }
    }
}
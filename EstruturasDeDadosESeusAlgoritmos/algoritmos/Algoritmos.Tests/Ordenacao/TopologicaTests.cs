
using Algoritmos.Ordenacao;
using FluentAssertions;

namespace Algoritmos.Tests.Ordenacao;

public class TopologicaTests
{
    [Test]
    public void Deve_Ordenar()
    {
        var grafo = new Dictionary<string, List<string>>{
            {"1", ["3", "2"]},
            {"5", ["2", "8"]},
            {"3", ["4"]},
            {"2", ["6"]},
            {"8", ["6"]},
            {"4", []},
            {"6", ["7"]},
            {"7", ["3"]}
        };
        var ordenacao = new Topologica();
        var arrayOrdenado = ordenacao.Ordenar(grafo);

        string[] arrayEsperado = ["1", "5", "2", "8", "6", "7", "3", "4"];
        arrayOrdenado.Should().BeEquivalentTo(arrayEsperado);
    }
}
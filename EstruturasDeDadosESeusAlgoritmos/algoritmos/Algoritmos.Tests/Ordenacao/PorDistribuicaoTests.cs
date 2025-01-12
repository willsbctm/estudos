using Algoritmos.Ordenacao;
using FluentAssertions;

namespace Algoritmos.Tests.Ordenacao;

public class PorDistribuicaoTests
{
    [Test]
    public void Deve_Ordenar()
    {
        string[] array = ["19", "13", "05", "27", "01", "26", "31", "16", "02", "09", "11", "21", "60", "07"];
        var ordenacao = new PorDistribuicao(2);
        var arrayOrdenado = ordenacao.Ordenar(array);

        string[] arrayEsperado = ["01", "02", "05", "07", "09", "11", "13", "16", "19", "21", "26", "27", "31", "60"];
        arrayOrdenado.Should().BeEquivalentTo(arrayEsperado);
    }
}
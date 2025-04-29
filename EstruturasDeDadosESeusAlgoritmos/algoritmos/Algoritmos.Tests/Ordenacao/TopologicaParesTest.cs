
using Algoritmos.Ordenacao;
using FluentAssertions;

namespace Algoritmos.Tests.Ordenacao;

public class TopologicaParesTests
{
    [Test]
    public void Deve_Ordenar()
    {
        var pares = new List<Par>{
            new() { Valor = 1, Sucessor = 2 },
            new() { Valor = 1, Sucessor = 3 },
            new() { Valor = 5, Sucessor = 2 },
            new() { Valor = 5, Sucessor = 8 },
            new() { Valor = 3, Sucessor = 4 },
            new() { Valor = 2, Sucessor = 6 },
            new() { Valor = 8, Sucessor = 6 },
            new() { Valor = 6, Sucessor = 7 },
            new() { Valor = 7, Sucessor = 3 }
        };
        var ordenacao = new TopologicaPares();
        var arrayOrdenado = ordenacao.Ordenar(pares, 8);

        int[] arrayEsperado = [1, 5, 2, 8, 6, 7, 3, 4];
        arrayOrdenado.Should().BeEquivalentTo(arrayEsperado);
    }
}
using System.Linq.Expressions;
using Algoritmos.Encadeado;
using FluentAssertions;

namespace Algoritmos.Tests.Encadeado;

public class ListaDuplamenteEncadeadaTests
{
    [Test]
    public void Deve_Inserir()
    {
        var lista = new ListaDuplamenteEncadeada();
        lista.Adicionar(new NoDuplamenteEncadeado("chave1"));

        var noInserido = lista.Buscar(new NoDuplamenteEncadeado("chave1"));
        var noEsperado = new NoDuplamenteEncadeado("chave1");
        noEsperado.Proximo = lista.ObterCabeca();
        noEsperado.Anterior = lista.ObterCabeca();

        noInserido.Should().BeEquivalentTo(noEsperado);
    }

    [Test]
    public void Deve_Buscar()
    {
        var lista = new ListaDuplamenteEncadeada();
        var chave1 = new NoDuplamenteEncadeado("chave1");
        var chave2 = new NoDuplamenteEncadeado("chave2");
        var chave3 = new NoDuplamenteEncadeado("chave3");
        lista.Adicionar(chave1);
        lista.Adicionar(chave2);
        lista.Adicionar(chave3);

        var noInserido = lista.Buscar(new NoDuplamenteEncadeado("chave2"));

        noInserido.Should().BeEquivalentTo(chave2);
        lista.Contar().Should().Be(3);
    }

    [Test]
    public void Deve_Remover()
    {
        var lista = new Lista();
        lista.Adicionar(new No("chave1"));
        lista.Adicionar(new No("chave2"));
        lista.Adicionar(new No("chave3"));

        lista.Remover(new No("chave2"));

        var primeiroNo = lista.Buscar(new No("chave1"));
        var noEsperado = new No("chave1");
        noEsperado.Proximo = new No("chave3");
        primeiroNo.Should().BeEquivalentTo(noEsperado);
        lista.Contar().Should().Be(2);
    }

    [Test]
    public void Deve_Remover_Todos_Nos()
    {
        var lista = new ListaDuplamenteEncadeada();
        lista.Adicionar(new NoDuplamenteEncadeado("chave1"));
        lista.Adicionar(new NoDuplamenteEncadeado("chave2"));

        lista.Remover(new NoDuplamenteEncadeado("chave1"));
        lista.Remover(new NoDuplamenteEncadeado("chave2"));

        lista.Contar().Should().Be(0);
    }
}
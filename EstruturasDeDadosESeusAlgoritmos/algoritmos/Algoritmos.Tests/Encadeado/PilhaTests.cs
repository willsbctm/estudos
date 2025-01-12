
using Algoritmos.Encadeado;
using FluentAssertions;

namespace Algoritmos.Tests.Encadeado;

public class PilhaTests
{
    [Test]
    public void Deve_Inserir()
    {
        var pilha = new Pilha();
        pilha.Adicionar(new No("chave1"));

        pilha.Contar().Should().Be(1);
    }

    [Test]
    public void Deve_Remover()
    {
        var pilha = new Pilha();
        pilha.Adicionar(new No("chave1"));

        var noInserido = pilha.Remover();
        var noEsperado = new No("chave1");

        noInserido.Should().BeEquivalentTo(noEsperado);
        pilha.Contar().Should().Be(0);
    }

    [Test]
    public void Deve_Remover_Ultimo()
    {
        var pilha = new Pilha();
        pilha.Adicionar(new No("chave1"));
        pilha.Adicionar(new No("chave2"));
        pilha.Adicionar(new No("chave3"));

        var noInserido = pilha.Remover();
        var noEsperado = new No("chave3");

        noInserido.Should().BeEquivalentTo(noEsperado);
        pilha.Contar().Should().Be(2);
    }

    [Test]
    public void Deve_Remover_Ultimos()
    {
        var pilha = new Pilha();
        pilha.Adicionar(new No("chave1"));
        pilha.Adicionar(new No("chave2"));
        pilha.Adicionar(new No("chave3"));

        pilha.Remover();
        pilha.Remover();
        pilha.Remover();

        pilha.Contar().Should().Be(0);
    }
}
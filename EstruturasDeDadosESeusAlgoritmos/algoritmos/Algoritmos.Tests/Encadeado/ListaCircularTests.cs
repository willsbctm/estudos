using Algoritmos.Encadeado;
using FluentAssertions;

namespace Algoritmos.Tests.Encadeado;

public class ListaCircularTests
{
    [Test]
    public void Deve_Inserir()
    {
        var lista = new ListaCircular();
        lista.Adicionar(new No("chave1"));

        var noInserido = lista.Buscar(new No("chave1"));
        var noEsperado = new No("chave1");
        noEsperado.Proximo = lista.ObterCabeca();

        noInserido.Should().BeEquivalentTo(noEsperado);
    }

    [Test]
    public void Deve_Buscar()
    {
        var lista = new ListaCircular();
        lista.Adicionar(new No("chave1"));
        lista.Adicionar(new No("chave2"));
        lista.Adicionar(new No("chave3"));

        var noInserido = lista.Buscar(new No("chave2"));
        var noEsperado = new No("chave2");
        var ultimoNo = new No("chave3");
        ultimoNo.Proximo = lista.ObterCabeca();
        noEsperado.Proximo = ultimoNo;

        noInserido.Should().BeEquivalentTo(noEsperado);
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
        var lista = new Lista();
        lista.Adicionar(new No("chave1"));
        lista.Adicionar(new No("chave2"));

        lista.Remover(new No("chave1"));
        lista.Remover(new No("chave2"));

        lista.Contar().Should().Be(0);
    }
}
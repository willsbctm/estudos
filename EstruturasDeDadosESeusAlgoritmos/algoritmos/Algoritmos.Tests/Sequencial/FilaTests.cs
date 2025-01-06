using Algoritmos.Sequencial;
using FluentAssertions;

namespace Algoritmos.Tests.Sequencial;
public class FilaTests
{
    [Test]
    public void Deve_Inserir()
    {
        var fila = new Fila(3);
        fila.Inserir("1");
        fila.Inserir("2");
        fila.Inserir("3");
    }

    [Test]
    public void Deve_Remover()
    {
        var fila = new Fila(3);
        fila.Inserir("1");
        fila.Inserir("2");
        fila.Inserir("3");

        var chave1 = fila.Remover();
        chave1.Should().Be("1");

        var chave2 = fila.Remover();
        chave2.Should().Be("2");

        fila.Inserir("4");
        fila.Inserir("5");

        var chave3 = fila.Remover();
        chave3.Should().Be("3");

        var chave4 = fila.Remover();
        chave4.Should().Be("4");

        var chave5 = fila.Remover();
        chave5.Should().Be("5");

        fila.Inserir("6");
        fila.Inserir("7");
        fila.Inserir("8");

        var chave = fila.Remover();
        chave.Should().Be("6");

        chave = fila.Remover();
        chave.Should().Be("7");

        chave = fila.Remover();
        chave.Should().Be("8");
    }
}

using Algoritmos.Sequencial;
using FluentAssertions;

namespace Algoritmos.Tests.Sequencial;

public class PilhaTests
{
    public class Inserir
    {
        [Test]
        public void Deve_Inserir_Item_Na_Posicao_Zero()
        {
            var pilha = new Pilha(10);
            pilha.Inserir("chave");

            var chave = pilha.Remover();
            chave.Should().Be("chave");
        }
    }

    public class Remover
    {
        [Test]
        public void Deve_Remover_Ultimo_Item_Da_Pilha()
        {
            var pilha = new Pilha(10);
            pilha.Inserir("chave1");
            pilha.Inserir("chave2");
            pilha.Inserir("chave3");
            pilha.Inserir("chave4");

            var chave4 = pilha.Remover();
            chave4.Should().Be("chave4");
            var chave3 = pilha.Remover();
            chave3.Should().Be("chave3");
        }
    }
}

using FluentAssertions;
using FluentAssertions.Execution;
using Algoritmos.Sequencial;

namespace Algoritmos.Tests.Sequencial;

public class ListaLinearTests
{
    public class Inserir
    {
        [Test]
        public void Deve_Inserir_Um_Valor_Na_Posicao_Zero()
        {
            var lista = new ListaLinear(10);

            var chave = "oi";
            lista.Inserir(chave);
            var posicao = lista.Buscar(chave);

            posicao.Should().Be(0);
        }

        [Test]
        public void Deve_Inserir_Um_Valor_Na_Posicao_Um()
        {
            var lista = new ListaLinear(10);
            lista.Inserir("chave");

            var chave = "oi";
            lista.Inserir(chave);
            var posicao = lista.Buscar(chave);

            posicao.Should().Be(1);
        }

        [Test]
        public void Deve_Inserir_Um_Valor_Na_Posicao_Tres()
        {
            var lista = new ListaLinear(10);
            lista.Inserir("chave1");
            lista.Inserir("chave2");
            lista.Inserir("chave3");

            var chave = "oi";
            lista.Inserir(chave);
            var posicao = lista.Buscar(chave);

            posicao.Should().Be(3);
        }

        [Test]
        public void Nao_Deve_Inserir_Um_Valor_Repetido()
        {
            var lista = new ListaLinear(10);

            var chave = "oi";
            lista.Inserir(chave);
            lista.Inserir(chave);
            var posicao = lista.Buscar(chave);

            posicao.Should().Be(0);
        }

        [Test]
        public void Deve_Lancar_Excecao_Ao_Inserir_Um_Valor_Alem_Do_Tamanho_Maximo()
        {
            var lista = new ListaLinear(1);

            lista.Inserir("chave1");
            Action acao = () => lista.Inserir("chave2");
            acao.Should().Throw<OverflowException>().WithMessage("Array is full");
        }
    }

    public class Buscar
    {
        [Test]
        public void Deve_Retornar_Nulo_Se_Chave_Nao_Existir_Na_Lista()
        {
            var lista = new ListaLinear(5);
            lista.Inserir("chave");

            var chaveBuscada = "chaveBuscada";
            lista.Buscar(chaveBuscada).Should().BeNull();
        }

        [Test]
        public void Deve_Retornar_Indice_Zero_Na_Busca_Do_Primeiro_Item_Da_Lista()
        {
            var chaveBuscada = "chaveBuscada";
            var lista = new ListaLinear(5);
            lista.Inserir(chaveBuscada);

            lista.Buscar(chaveBuscada).Should().Be(0);
        }

        [Test]
        public void Deve_Retornar_Indice_Tres_Na_Busca_Do_Quarto_Item_Da_Lista()
        {
            var lista = new ListaLinear(10);
            lista.Inserir("chave1");
            lista.Inserir("chave2");
            lista.Inserir("chave3");
            var chaveBuscada = "chaveBuscada";
            lista.Inserir(chaveBuscada);
            lista.Inserir("chave4");
            lista.Inserir("chave5");

            lista.Buscar(chaveBuscada).Should().Be(3);
        }

        [Test]
        public void Deve_Retornar_Ultimo_Indice_Na_Busca_Pelo_Ultimo_Item_Da_Lista()
        {
            var lista = new ListaLinear(10);
            lista.Inserir("chave1");
            lista.Inserir("chave2");
            lista.Inserir("chave3");
            var chaveBuscada = "chaveBuscada";
            lista.Inserir(chaveBuscada);

            lista.Buscar(chaveBuscada).Should().Be(3);
        }
    }

    public class Remover
    {
        [Test]
        public void Nao_Deve_Ter_Nenhuma_Acao_Se_Item_Nao_Existir_Na_Lista()
        {
            var lista = new ListaLinear(10);
            lista.Inserir("chave1");
            lista.Inserir("chave2");

            lista.Remover("chave3");

            lista.Contar().Should().Be(2);
        }

        [Test]
        public void Deve_Remover_Item_Da_Lista()
        {
            var lista = new ListaLinear(10);
            lista.Inserir("chave1");
            var chaveRemovida = "chave2";
            lista.Inserir(chaveRemovida);

            lista.Remover(chaveRemovida);

            using var _ = new AssertionScope();
            lista.Buscar(chaveRemovida).Should().BeNull();
            lista.Contar().Should().Be(1);
        }

        [Test]
        public void Deve_Remover_Item_Da_Lista_E_Reorganizar_Itens()
        {
            var lista = new ListaLinear(5);
            lista.Inserir("chave1");
            var chaveRemovida = "chave2";
            lista.Inserir(chaveRemovida);
            lista.Inserir("chave3");
            lista.Inserir("chave4");

            lista.Remover(chaveRemovida);

            using var _ = new AssertionScope();
            lista.Obter(0).Should().Be("chave1");
            lista.Obter(1).Should().Be("chave3");
            lista.Obter(2).Should().Be("chave4");
            lista.Contar().Should().Be(3);
        }
    }
}
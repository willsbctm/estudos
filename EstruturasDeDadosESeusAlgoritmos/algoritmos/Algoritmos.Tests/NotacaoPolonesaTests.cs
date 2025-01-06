using FluentAssertions;

namespace Algoritmos.Tests;
public class NotacaoPolonesaTests
{
    [Test]
    public void Deve_Converter_Expressao_Simples()
    {
        var expressao = "(A*B)";

        var notacao = new NotacaoPolonesa();
        var resultado = notacao.Converter(expressao);

        resultado.Should().Be("*AB");
    }

    [Test]
    public void Deve_Converter_Expressao_Complexa()
    {
        var expressao = "((A*B)-(C/D))";

        var notacao = new NotacaoPolonesa();
        var resultado = notacao.Converter(expressao);

        resultado.Should().Be("-*AB/CD");
    }
}

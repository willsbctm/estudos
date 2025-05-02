namespace Implementacoes.Tests;

public class PrimoTests
{
    [Fact]
    public void UmNaoÉPrimo() => new Primo().EhPrimo(1).Should().BeFalse();

    [Fact]
    public void DoisÉPrimo() => new Primo().EhPrimo(2).Should().BeTrue();

    [Fact]
    public void TresÉPrimo() => new Primo().EhPrimo(3).Should().BeTrue();

    [Fact]
    public void QuatroNaoÉPrimo() => new Primo().EhPrimo(4).Should().BeFalse();

    [Fact]
    public void NoventaSeteÉPrimo() => new Primo().EhPrimo(97).Should().BeTrue();
}
namespace Implementacoes.Tests;

public class ConversorBasesTests
{
    [Fact]
    public void DeveConverterDoisPara10()
    {
        var conversor = new ConversorBases();
        var valorDecimal = 2;
        conversor.ConverterParaBinario(valorDecimal).Should().Be("10");
    }

    [Fact]
    public void DeveConverterVinteCincoPara11001()
    {
        var conversor = new ConversorBases();
        var valorDecimal = 25;
        conversor.ConverterParaBinario(valorDecimal).Should().Be("11001");
    }

    [Fact]
    public void DeveConverter10001101ParaCentoVinteOito()
    {
        var conversor = new ConversorBases();
        var valorDecimal = "10001101";
        conversor.ConverterParaDecimal(valorDecimal).Should().Be(141);
    }

    [Fact]
    public void DeveConverter10ParaDois()
    {
        var conversor = new ConversorBases();
        var valorDecimal = "10";
        conversor.ConverterParaDecimal(valorDecimal).Should().Be(2);
    }
}
namespace Implementacoes.Tests;

public class MergeSortedListTest
{
    [Fact]
    public void DeveMergearListas(){
        int[][] listas = [[1,3,5],[2,4,6],[7,10]];

        var merge = new MergeSortedList();
        var resultado = merge.Merge(listas);

        int[] listaEsperada = [1,2,3,4,5,6,7,10];
        resultado.Should().BeEquivalentTo(listaEsperada);
    }
}
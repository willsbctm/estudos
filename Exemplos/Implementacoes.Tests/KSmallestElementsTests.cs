namespace Implementacoes.Tests;

public class KSmallestElementsTests
{
    [Fact]
    public void Oi(){
        int[][] matrix = [[1,5,9],[10,11,13], [12,13,15]];
        int k = 8;

        var oi = new KSmallestElements().KthSmallest(matrix, k);

    }
}
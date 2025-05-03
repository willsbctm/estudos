namespace Implementacoes.Tests;

public class KClosestPointsTests
{
    [Fact]
    public void DeveEncontrarPontosMaisPertoViaPriorityQueue(){
        var c = new KClosestPoints();

        List<(int,int)> points = [
            (10,0),
            (1,1),
            (1,0),
            (3,3),
        ];
        var resposta = c.ObterViaPriorityQueue(points, 2);
        resposta.Should().BeEquivalentTo([(1,0), (1,1)], opt => opt.WithStrictOrdering());
    }
}
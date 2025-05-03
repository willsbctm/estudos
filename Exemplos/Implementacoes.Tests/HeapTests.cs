namespace Implementacoes.Tests;

public class HeapTests
{
    [Fact]
    public void DeveAdicionar5(){
        var heap = new Heap<(int,int)>();
        heap.Inserir(new HeapItem<(int,int)>((0,0), 5));

        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((0,0), 5));
    }

    [Fact]
    public void DeveAdicionar5SeguidoDe3(){
        var heap = new Heap<(int,int)>();
        heap.Inserir(new HeapItem<(int,int)>((0,0), 5));
        heap.Inserir(new HeapItem<(int, int)>((0,3), 3));

        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int, int)>((0,3), 3));
    }

    [Fact]
    public void DeveAdicionarValorDoisEOrganizarArvore(){
        List<HeapItem<(int,int)>> itens = [
            new ((1,0), 1),
            new ((1,2), 3),
            new ((3,2), 5),
            new ((2,2), 4),
            new ((10,1), 11),
            new ((10,0), 10),
        ];

        var heap = new Heap<(int,int)>(itens);

        var novoItem = new HeapItem<(int,int)>((2,0), 2);
        heap.Inserir(novoItem);

        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((1,0), 1));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((2,0), 2));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((1,2), 3));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((2,2), 4));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((3,2), 5));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((10,0), 10));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((10,1), 11));
        heap.Remover().Should().BeNull();
    }

    [Fact]
    public void DeveRemoverCorretamente(){
        List<HeapItem<(int,int)>> itens = [
            new ((1,0), 1),
            new ((1,2), 3),
            new ((2,0), 2),
            new ((2,2), 4),
            new ((10,1), 11),
            new ((10,0), 10),
            new ((3,2), 5)
        ];

        var heap = new Heap<(int,int)>(itens);

        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((1,0), 1));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((2,0), 2));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((1,2), 3));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((2,2), 4));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((3,2), 5));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((10,0), 10));
        heap.Remover().Should().BeEquivalentTo(new HeapItem<(int,int)>((10,1), 11));
        heap.Remover().Should().BeNull();
    }
}
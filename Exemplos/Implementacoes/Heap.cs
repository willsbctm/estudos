namespace Implementacoes;

public record HeapItem<T>(T Item, int Distancia);

public class Heap<T>{
    public List<HeapItem<T>> heap = [];

    public Heap() { }

    public Heap(List<HeapItem<T>> heap) => heap.ForEach(Inserir);

    public void Inserir(HeapItem<T> item){
        heap.Add(item);
        var ultimoIndice = heap.Count - 1;
        BubbleUp(ultimoIndice);
    }

    public HeapItem<T>? Remover(){
        if(heap.Count == 0)
            return null;
        var minValue = heap[0];
        var ultimoIndice = heap.Count - 1;
        heap[0] = heap[ultimoIndice];
        heap.RemoveAt(ultimoIndice);

        BubbleDown(0);
        return minValue;
    }

    public void BubbleUp(int indice){
        if(indice < 1)
            return;

        var novoItem = heap[indice];

        var indicePai = ObterPai(indice);

        var pai = heap[indicePai];

        if(novoItem.Distancia < pai.Distancia){
            Swap(indice, indicePai);
            BubbleUp(indicePai);
        }
    }

    public void BubbleDown(int indice){
        if(heap.Count == 0)
            return;
        var menorValor = heap[indice];
        var indiceComMenorValor = indice;

        var indiceFilhoEsquerdo = ObterFilhoEsquerdo(indice);
        if(indiceFilhoEsquerdo > -1 && menorValor.Distancia > heap[indiceFilhoEsquerdo].Distancia){
            menorValor = heap[indiceFilhoEsquerdo];
            indiceComMenorValor = indiceFilhoEsquerdo;
        }
        var indiceFilhoDireito = ObterFilhoDireito(indice);
        if(indiceFilhoDireito > -1 && menorValor.Distancia > heap[indiceFilhoDireito].Distancia){
            menorValor = heap[indiceFilhoDireito];
            indiceComMenorValor = indiceFilhoDireito;
        }

        if(indiceComMenorValor != indice){
            Swap(indiceComMenorValor, indice);
            BubbleDown(indiceComMenorValor);
        }
    }

    public void Swap(int indice, int pai){
        var temp = heap[indice];
        heap[indice] = heap[pai];
        heap[pai] = temp;
    }

    public int ObterPai(int indice){
        int pai = (indice - 1) / 2;
       
        return indice >= 1 ? pai : -1;
    }

    public int ObterFilhoEsquerdo(int indice){
        var filho = (2 * indice) + 1;

        return filho < heap.Count ? filho : -1;
    }

    public int ObterFilhoDireito(int indice){
        var filho = (2 * indice) + 2;

        return filho < heap.Count ? filho : -1;
    }
}

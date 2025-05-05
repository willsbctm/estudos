namespace Implementacoes;
public class MergeSortedList{
    public record ItemDaLista(int[] lista, int indice);
    public int[] Merge(int[][] listas){
        var heap = new Heap<ItemDaLista>();

        var tamanho = listas.Sum(x => x.Length);
        int[] resposta = new int[tamanho];

        for(var i = 0; i < listas.Length; i ++){
            var item = new ItemDaLista(listas[i], 0);

            heap.Inserir(new HeapItem<ItemDaLista>(item, listas[i][0]));
        }

        var itemCorrente = heap.Remover();
        var indice = 0;
        while(itemCorrente != null){
            resposta[indice] = itemCorrente.Distancia;

            var proximoIndice = itemCorrente.Item.indice + 1;

            if(proximoIndice < itemCorrente.Item.lista.Length){
                var proximoItem = itemCorrente.Item.lista[proximoIndice];
                var item = new ItemDaLista(itemCorrente.Item.lista, proximoIndice);
                heap.Inserir(new HeapItem<ItemDaLista>(item, proximoItem));
            }

            indice++;
            itemCorrente = heap.Remover();
        };

        return resposta;
    }
}

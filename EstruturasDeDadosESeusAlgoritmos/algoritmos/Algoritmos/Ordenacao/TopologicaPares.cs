namespace Algoritmos.Ordenacao;

public class Par{
    public int Valor { get; set; }
    public int Sucessor { get; set; }
}

public class Item{
    public int ContadorAntecessores { get;set; } = 0;
    public List<int> Sucessores { get;set; } = [];
}
public class TopologicaPares{
    public List<int> Ordenar(List<Par> pares, int total){
        // Iniciar
        var listaComContador = new Item[total];
        for(var i = 0; i < total; i++){
            listaComContador[i] = new Item();
        }

        //Encontrar antecessores  
        foreach(var no in pares){
            listaComContador[no.Valor - 1].Sucessores.Add(no.Sucessor - 1);
            listaComContador[no.Sucessor - 1].ContadorAntecessores++;
        }

        //Encontrar os nós sem antecessores
        var fila = new Queue<int>();
        for(var i = 0; i < total; i++){
            if(listaComContador[i].ContadorAntecessores == 0)
                fila.Enqueue(i);
        }

        //Repetir para o restante da lista
        var listaOrdenada = new List<int>();
        while(fila.Count > 0){
            var atual = fila.Dequeue();
            listaOrdenada.Add(atual + 1);

            //Decrementar em sucessores
            foreach(var vizinho in listaComContador[atual].Sucessores){
                listaComContador[vizinho].ContadorAntecessores--;
                    
                if(listaComContador[vizinho].ContadorAntecessores == 0)
                    fila.Enqueue(vizinho);
            }
            
        }
        return listaOrdenada;
    }
}
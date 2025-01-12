namespace Algoritmos.Ordenacao;

public class Topologica{
    public List<string> Ordenar(Dictionary<string, List<string>> grafo){
        // Iniciar
        var listaComContador = new Dictionary<string, int>();
        foreach(var no in grafo.Keys){
            listaComContador[no] = 0;
        }

        //Encontrar antecessores  
        foreach(var no in grafo.Keys){
            foreach(var vizinho in grafo[no]){
                listaComContador[vizinho]++;
            }
        }

        //Encontrar os nós sem antecessores
        var fila = new Queue<string>();
        foreach(var no in listaComContador){
            if(no.Value == 0)
                fila.Enqueue(no.Key);
        }

        //Repetir para o restante da lista
        var listaOrdenada = new List<string>();
        while(fila.Count > 0){
            var atual = fila.Dequeue();
            listaOrdenada.Add(atual);

            //Decrementar em predecessores
            foreach(var vizinho in grafo[atual]){
                listaComContador[vizinho]--;
                    
                if(listaComContador[vizinho] == 0)
                    fila.Enqueue(vizinho);
            }
            
        }
        return listaOrdenada;
    }
}
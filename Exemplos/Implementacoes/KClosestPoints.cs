namespace Implementacoes;
public class KClosestPoints{

    public int CalcularDistancia(int x2, int y2, int x1, int y1) {
        var distanciaX = x2 - x1;
        var distanciaY = y2 - y1;
        var distancia = Math.Pow(distanciaX, 2) + Math.Pow(distanciaY, 2);

        return (int)distancia;
    }

    public List<(int,int)> ObterViaPriorityQueue(List<(int, int)> points, int k){
        var heap = new PriorityQueue<(int, int), int>();

        (int, int) pontoBase = (0,0);

        foreach (var point in points){
            var distancia = CalcularDistancia(point.Item1, point.Item2, pontoBase.Item1, pontoBase.Item2);
            heap.Enqueue(point, distancia);
        }

        var resultado = new List<(int, int)>();
        for(var i = 0; i < k; i ++){
            resultado.Add(heap.Dequeue());
        }

        return resultado;
    }
}
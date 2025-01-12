namespace Algoritmos.Ordenacao;

public class PorDistribuicao{
    private readonly int _algarismos;

    public PorDistribuicao(int algarismos){
        _algarismos = algarismos;
    }


    public string[] Ordenar(string[] array){
        Queue<string>[] filas = new Queue<string>[10];

        for(int a = 0 ; a < 10; a ++){
            filas[a] = [];
        }

        for(int i = 0; i < _algarismos;i ++){
            for(int j = 0; j < array.Length; j ++){
                var valor = array[j];
                var parte = int.Parse(valor.Substring(valor.Length - (1 + i), 1));
                filas[parte].Enqueue(valor);
            }

            var indiceFila = 0;
            for(var k = 0; k < 10; k++){
                var fila = filas[k];
                while(fila.Count > 0){
                    array[indiceFila] = fila.Dequeue();
                    indiceFila++;
                }
            }
        }

        return array;
    }
}
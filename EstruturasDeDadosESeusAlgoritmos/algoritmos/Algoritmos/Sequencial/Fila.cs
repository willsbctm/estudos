namespace Algoritmos.Sequencial;

public class Fila(int tamanho)
{
    private readonly string[] array = new string[tamanho];
    private int topo = 0;
    private int calda = 0;

    public void Inserir(string chave)
    {
        var posicao = (calda % tamanho) + 1;
        if (calda - topo >= tamanho - 1)
            throw new OverflowException("Array is full");

        array[posicao - 1] = chave;
        calda = posicao;

        if (topo == 0)
            topo = 1;
    }

    public string Remover()
    {
        if(topo == 0)
            throw new OverflowException("Array is empty");

        var posicao = (topo % tamanho) + 1;
        var chave = array[topo - 1];

        if (topo - calda == 0)
        {
            topo = 0;
            calda = 0;
        }
        else
            topo = posicao;

        return chave;
    }
}

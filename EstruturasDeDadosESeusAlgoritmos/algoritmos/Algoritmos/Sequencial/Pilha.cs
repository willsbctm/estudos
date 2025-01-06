namespace Algoritmos.Sequencial;

public class Pilha(int tamanho)
{
    private readonly string[] array = new string[tamanho];
    private int topo = -1;

    public void Inserir(string chave)
    {
        if (topo >= array.Length)
            throw new OverflowException("Array is full");

        topo++;
        array[topo] = chave;
    }

    public string Remover()
    {
        if (topo < 0)
            throw new ArgumentOutOfRangeException("Array is empty");

        var chave = array[topo];
        topo--;
        return chave;
    }
}

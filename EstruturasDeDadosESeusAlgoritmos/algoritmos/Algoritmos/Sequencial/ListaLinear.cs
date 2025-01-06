namespace Algoritmos.Sequencial;

public class ListaLinear(int tamanho)
{
    private readonly string[] array = new string[tamanho];
    private int ultimoIndice = 0;

    public void Inserir(string chave)
    {
        var exists = Buscar(chave);
        if (exists != null)
            return;

        if (ultimoIndice >= array.Length)
            throw new OverflowException("Array is full");

        array[ultimoIndice] = chave;
        ultimoIndice++;
    }

    public void Remover(string chave)
    {
        var exists = Buscar(chave);
        if (exists == null)
            return;

        for (int i = exists.Value; i < ultimoIndice; i++)
            array[i] = array[i + 1];

        ultimoIndice--;
    }

    public int? Buscar(string chave) {
        for (int i = 0; i < ultimoIndice; i++)
            if (array[i].Equals(chave))
                return i;

        return null;
    }

    public int Contar() => ultimoIndice;

    public string Obter(int indice)
    {
        if (indice >= ultimoIndice)
            throw new OverflowException("Invalid index");

        return array[indice];
    }

    public unsafe List<(long, string)> ObterPosicaoDaMemoria()
    {
        var enderecos = new List<(long, string)>();

        fixed (string* ptr = &array[0]) 
        {
            for (int i = 0; i < ultimoIndice; i++)
                enderecos.Add(((long)(ptr + i), *(ptr + i)));
        }

        return enderecos;
    }
}

namespace Algoritmos.Encadeado;

public class No(string chave)
{
    public string Chave { get; set; } = chave;
    public No? Proximo { get; set; } = null;
}

namespace Algoritmos.Encadeado;

public class NoDuplamenteEncadeado(string chave)
{
    public string Chave { get; set; } = chave;
    public NoDuplamenteEncadeado? Proximo { get; set; } = null;
    public NoDuplamenteEncadeado? Anterior { get; set; } = null;
}
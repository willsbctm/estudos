namespace Algoritmos.Encadeado;

public class ListaDuplamenteEncadeada
{
    private readonly NoDuplamenteEncadeado Cabeca;

    public ListaDuplamenteEncadeada()
    {
        Cabeca = new NoDuplamenteEncadeado("");
        Cabeca.Proximo = Cabeca;
        Cabeca.Anterior = Cabeca;
    }

    public void Adicionar(NoDuplamenteEncadeado no){
        var calda = Calda();
        calda.Proximo = no;
        no.Anterior = calda;

        no.Proximo = Cabeca;
        Cabeca.Anterior = no;
    }

    public void Remover(NoDuplamenteEncadeado no){
        var noProcurado = Buscar(no) ?? throw new InvalidOperationException("Nó não existe na lista");

        var anterior = noProcurado.Anterior;
        var proximo = noProcurado.Proximo;

        anterior.Proximo = proximo;
        proximo.Anterior = anterior;
    }

    public NoDuplamenteEncadeado? Buscar(NoDuplamenteEncadeado no){
        var noAtual = Cabeca.Proximo;

        while (noAtual != Cabeca){
            if(noAtual.Chave == no.Chave)
                return noAtual;

            noAtual = noAtual.Proximo;
        }

        return null;;
    }

    public int Contar(){
        var contador = 0;
        var no = Cabeca;
        while(no.Proximo != Cabeca){
            contador++;
            no = no.Proximo;
        }

        return contador;
    }

    public NoDuplamenteEncadeado Calda(){
        return Cabeca.Anterior;
    }

    public NoDuplamenteEncadeado ObterCabeca() => Cabeca;
}

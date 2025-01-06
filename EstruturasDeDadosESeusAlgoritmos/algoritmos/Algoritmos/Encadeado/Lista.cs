namespace Algoritmos.Encadeado;

public class Lista
{
    private readonly No Cabeca;

    public Lista()
    {
        Cabeca = new No("");
    }

    public void Adicionar(No no){
        var calda = Calda();
        calda.Proximo = no;
        no.Proximo = null;
    }

    public void Remover(No no){
        var noAnterior = BuscarAnterior(no) ?? throw new InvalidOperationException("Nó não existe na lista");

        var noProcurado = noAnterior.Proximo!;

        noAnterior.Proximo = noProcurado.Proximo;
    }

    public No? Buscar(No no){
        var noAnterior = BuscarAnterior(no);

        return noAnterior != null ? noAnterior.Proximo : null;
    }

    public No? BuscarAnterior(No no){
        var noAtual = Cabeca;

        while(noAtual.Proximo != null){
            if(noAtual.Proximo.Chave == no.Chave)
                return noAtual;

            noAtual = noAtual.Proximo;
        }

        return null;;
    }

    public int Contar(){
        var contador = 0;
        var no = Cabeca;
        while(no.Proximo != null){
            contador++;
            no = no.Proximo;
        }

        return contador;
    }

    public No Calda(){
        var no = Cabeca;
        while(no.Proximo != null){
            no = no.Proximo;
        }

        return no;
    }
}

public class No(string chave)
{
    public string Chave { get; set; } = chave;
    public No? Proximo { get; set; } = null;
}
namespace Algoritmos.Encadeado;

public class ListaCircular
{
    private readonly No Cabeca;

    public ListaCircular()
    {
        Cabeca = new No("");
        Cabeca.Proximo = Cabeca;
    }

    public void Adicionar(No no){
        var calda = Calda();
        calda.Proximo = no;
        no.Proximo = Cabeca;
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

        while(noAtual.Proximo != Cabeca){
            if(noAtual.Proximo.Chave == no.Chave)
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

    public No Calda(){
        var no = Cabeca;
        while(no.Proximo != Cabeca){
            no = no.Proximo;
        }

        return no;
    }

    public No ObterCabeca() => Cabeca;
}

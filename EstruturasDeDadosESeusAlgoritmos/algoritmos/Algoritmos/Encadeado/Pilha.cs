namespace Algoritmos.Encadeado;

public class Pilha
{
    private No? Cabeca;

    public void Adicionar(No no){
        if(Cabeca != null){
            no.Proximo = Cabeca;
        }

        Cabeca = no;
    }

    public No Remover(){
        if(Cabeca == null) 
            throw new InvalidOperationException("Pilha vazia");

        var no = Cabeca;

        Cabeca = Cabeca.Proximo;

        no.Proximo = null;

        return no;
    }

    public int Contar(){
        if(Cabeca == null)
            return 0;

        var contador = 1;
        var no = Cabeca;
        while(no.Proximo != null){
            contador++;
            no = no.Proximo;
        }

        return contador;
    }
}

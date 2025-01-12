namespace Algoritmos.Encadeado;

public class Fila
{
    private No? Cabeca;
    private No? Calda;

    public void Adicionar(No no){
        if(Cabeca == null || Calda == null){
            Cabeca = Calda = no;
        }
        else{
            var anterior = Calda;
            anterior.Proximo = no;
            Calda = no;
        }

    }

    public No Remover(){
        if(Cabeca == null) 
            throw new InvalidOperationException("Fila vazia");

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

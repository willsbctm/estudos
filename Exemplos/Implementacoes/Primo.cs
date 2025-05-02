namespace Implementacoes;

public class Primo{
    public bool EhPrimo(int valor){

        if(valor < 2)
            return false;
        
        var limite = (int)Math.Sqrt(valor) + 1;

        for(var i = 2; i < limite; i ++){
            if(valor % i == 0){
                return false;
            } 
        }

        return true;
    }
}
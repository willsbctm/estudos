// See https://aka.ms/new-console-template for more information
namespace ConversorBases;

public class Conversor{
    public string ConverterParaBinario(int valor){

        var dividento = valor;
        var divisor = 2;
        var quociente = dividento / divisor;
        var resto = dividento % divisor;

        return quociente < 2 ? $"{quociente}{resto}" : $"{ConverterParaBinario(quociente)}{resto}";
    }

    public int ConverterParaDecimal(string valor){

        return valor.Length < 2 ? Calc(valor) : Calc(valor) + ConverterParaDecimal(valor[1..]);

        static int Calc(string valor)
            => int.Parse(valor[0].ToString()) * ((int)Math.Pow(2, valor.Length - 1));
    }
}
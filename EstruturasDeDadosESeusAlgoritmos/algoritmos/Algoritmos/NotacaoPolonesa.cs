namespace Algoritmos;

public class NotacaoPolonesa
{
    public string Converter(string notacaoComParenteses)
    {
        var stack  = new Stack<string>();

        for (var i = 0; i < notacaoComParenteses.Length; i++)
        {
            if (notacaoComParenteses[i] == '(')
                continue;

            if (notacaoComParenteses[i] == ')')
            {
                var operandoDois = stack.Pop();
                var operador = stack.Pop();
                var operandoUm = stack.Pop();

                var operacao = $"{operador}{operandoUm}{operandoDois}";

                stack.Push(operacao);
            }
            else
            {
                stack.Push(notacaoComParenteses[i].ToString());
            }
         }

        return stack.Pop();
    }
}

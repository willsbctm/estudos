namespace Implementacoes;
public class KSmallestElements{
    public int KthSmallest(int[][] matrix, int k)
    {
        int n = matrix.Length;

        // PriorityQueue<(value, row, col), value>
        var heap = new PriorityQueue<(int val, int row, int col), int>();
        heap.Enqueue((matrix[0][0], 0, 0), matrix[0][0]);

        int[] columnTop = new int[n];  // topo de cada coluna
        int[] rowFirst = new int[n];   // início de cada linha

        while (k > 1)
        {
            k--;
            var (val, row, col) = heap.Dequeue();
            rowFirst[row] = col + 1;

            // Elemento à direita, se todos acima já foram processados
            if (col + 1 < n && columnTop[col + 1] == row)
            {
                heap.Enqueue((matrix[row][col + 1], row, col + 1), matrix[row][col + 1]);
            }

            columnTop[col] = row + 1;

            // Elemento abaixo, se todos à esquerda já foram processados
            if (row + 1 < n && rowFirst[row + 1] == col)
            {
                heap.Enqueue((matrix[row + 1][col], row + 1, col), matrix[row + 1][col]);
            }
        }

        return heap.Peek().val;
    }
}

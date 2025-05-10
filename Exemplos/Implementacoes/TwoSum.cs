namespace Implementacoes;

public class TwoSum{
    public int[]? Calc(int[] nums, int target){

        var hashTable = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++){
            var y = target - nums[i];

            if(hashTable.ContainsKey(y)){
                return [hashTable[y], i];
            }
            hashTable.Add(nums[i], i);
        }

        return null;
    }
}
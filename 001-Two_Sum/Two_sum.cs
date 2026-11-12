namespace LeetCode_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int target = 9;
            int[] result = program.TwoSum(program.nums, target);

            if (result.Length == 2)
            {
                Console.WriteLine($"A két index: {result[0]} és {result[1]}");
            }
            else
            {
                Console.WriteLine("Nem található megfelelő indexpár.");
            }
        }

        int[] nums = new int[] { 2, 7, 11, 15 };

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }
}

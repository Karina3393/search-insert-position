namespace search_insert_position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return left; 
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            int result = solution.SearchInsert(nums, target);
            Console.WriteLine($"Индекс для вставки: {result}");

            target = 2;
            result = solution.SearchInsert(nums, target);
            Console.WriteLine($"Индекс для вставки: {result}");

            target = 7;
            result = solution.SearchInsert(nums, target);
            Console.WriteLine($"Индекс для вставки: {result}");

            target = 0;
            result = solution.SearchInsert(nums, target);
            Console.WriteLine($"Индекс для вставки: {result}");
        }
    }
}
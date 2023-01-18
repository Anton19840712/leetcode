namespace EasyLevel;

public class TwoSumSolution1
{
	public int[] TwoSum(int[] nums, int target)
	{
		var returnArray = Array.Empty<int>();

		for (var i = 0; i <= nums.Length; i++)
		{
			for (var k = i + 1; k <= nums.Length; k++)
			{
				if (k + 1 > nums.Length)
				{
					break;
				}
				var firstValue = nums[i];

				var secondValue = nums[k];

				if (firstValue + secondValue == target)
				{
					returnArray = returnArray.Concat(new[] { i, k }).ToArray();

					break;
				}
			}
		}
		return returnArray;
	}
}
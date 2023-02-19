namespace EasyLevel;

public static class Solution
{
	public static int SingleNumber(int[] nums)
	{
		if (nums == null) return default;

		int counter = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 0; j < nums.Length; j++)
			{
				var firstElement = nums[i];
				var secondElement = nums[j];
				if (firstElement == secondElement)
				{
					counter++;
				}
			}

			if (counter == 1)
			{
				return nums[i];
			}
			counter = 0;
		}
		return default;
	}
}
namespace EasyLevel;

public static class LongestCommonPrefix
{
	public static string FindLongestCommonPrefix(this string[] flowers)
	{
		//var flowers = new string[]{"flower", "flow", "flight"};
		//{"flower", "flow", "flight"}
		//нужно всегда определяться, сколько будет циклов и сколько ты будешь бежать по внешнему, а сколько по внутреннему.

		var list = new List<string>();
		var flowersMinLength = flowers.MinBy(x => x.Length)!.Length;
		var flowersMaxLength = flowers.MaxBy(x => x.Length)!.Length;
		var orderedFlowersByLengthCount = flowers.OrderBy(x => x.Length).Count();
		var result = new List<string>();

		if (orderedFlowersByLengthCount <= 200 && flowersMaxLength <=200)
		{
			for (int z = 0; z < flowersMinLength; z++)
			{
				for (int i = 0; i < orderedFlowersByLengthCount; i++)//run by collection of flowers
				{
					var flower = flowers[i].Substring(z, 1);
					list.Add(flower);
				}

				var distinct = list.Distinct();

				var isAllEqual = distinct.Count() == 1;

				if (isAllEqual)
				{
					result.Add(distinct.FirstOrDefault());
					list.Clear();
				}
				else
				{
					break;
				}
			}

			return string.Join("", result);
		}
		return default;
	}
}
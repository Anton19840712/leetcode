namespace EasyLevelHelpingLogic;

public class LongestCommonPrefixHelpLogicTwo
{
	//substring - откуда, на сколько символов
	public static void Execute()
	{
		String[] pairs = { "Color1=red", "Color2=green", "Color3=blue", "Title=Code Repository" };
		foreach (var pair in pairs)
		{
			int position = pair.IndexOf("=", StringComparison.Ordinal);//то есть та позиция, которая слева. Представь, что каретка мигает до символа '=' равен в первом случае 6
			if (position < 0)
				continue;

			var first = pair.Substring(0, position);//start index and position
			var second = pair.Substring(position + 1);//стартовый индекс, от которого берется вся подстрока до ее конца.

			Console.WriteLine("Key: {0}, Value: '{1}'", first, second);
		}
	}
}
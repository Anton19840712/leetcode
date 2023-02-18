namespace EasyLevelHelpingLogic;

public class LongestCommonPrefixHelpLogicOne
{
	public static void Execute()
	{
		string[] info = { "Name: Felica Walker", "Title: Mz.",
			"Age: 47", "Location: Paris", "Gender: F"};

		Console.WriteLine("The initial values in the array are:");
		foreach (string s in info)
			Console.WriteLine(s);

		Console.WriteLine("\nWe want to retrieve only the key information. That is:");
		foreach (string s in info)
		{
			var found = s.IndexOf(": ", StringComparison.Ordinal);
			Console.WriteLine("   {0}", s.Substring(found + 2));//означает все, что дальше этого символа до конца строки
		}

	}
}
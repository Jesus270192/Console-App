using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ExerciseInInterviews
{
  public  class Anagram
    {
		public void DoAnagram()
		{
			List<string> words = new List<string>() { "roma", "abc", "amor", "cba", "mora", "aab", "ramo", "bba", "omar", "abb", "poder", "red", "pedro", "edr", "saunas", "def", "susana" };
			List<string> aux = new List<string>() { "roma", "abc", "amor", "cba", "mora", "aab", "ramo", "bba", "omar", "abb", "poder", "red", "pedro", "edr", "saunas", "def", "susana" };
			List<string> theseWordsAreAnagram, skipword;
			string value1, value2;
			theseWordsAreAnagram = skipword = new List<string>();

			foreach (string value in words)
			{
				if (skipword.Count(s => s == value) > 0)
				{
					continue;
				}

				theseWordsAreAnagram = new List<string>();
				skipword.Add(value);
				aux.Remove(value);

				value2 = String.Concat(value.OrderBy(c => c));

				foreach (string valueAux in aux)
				{
					value1 = String.Concat(valueAux.OrderBy(c => c));


					if (value1 == value2)
					{
						theseWordsAreAnagram.Add(valueAux);
					}
				}

				if (theseWordsAreAnagram.Count() > 0)
				{
					Console.WriteLine(value + " " + String.Join(" ", theseWordsAreAnagram.ToArray()) + " ->>> Anagram");
				}
				else
				{
					Console.WriteLine(value + "-->>> No Anagram");
				}

				foreach (var item in theseWordsAreAnagram)
				{
					skipword.Add(item);
					aux.Remove(item);
				}
			}
		}
	}
}

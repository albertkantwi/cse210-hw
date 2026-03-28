public class Verse
{


    public static Dictionary<int, List<string>> CreateScripture(ScriptureReference currentReference)

    {
    List<string> _verseText = new List<string>();

    Dictionary<int, List<string>> _scriptureVerses = new Dictionary<int, List<string>>();
      

        int begin = currentReference.GetBeginningVerse();
        int? end = currentReference.GetEndingVerse();

        if (end != null)
        {
            for (int i = begin; i <= end; i++)
            {
                List<string> verseStrings = new List<string>(); 
                Console.WriteLine($"Please enter the text of verse {i}.");
                string text = Console.ReadLine();
                string[] splitStringArray = text.Split(" ");
                foreach (string word in splitStringArray)
                {
                    verseStrings.Add(word);
                }
                _scriptureVerses.Add(i, verseStrings);
            }
        }
        else
        {
            Console.WriteLine($"Please enter the text of verse {begin}.");
            string text = Console.ReadLine();
            string[] splitStringArray = text.Split(" ");
            foreach (string word in splitStringArray)
            {
                _verseText.Add(word);
            }
            _scriptureVerses.Add(begin, _verseText);
        }


        return _scriptureVerses;
    }
}
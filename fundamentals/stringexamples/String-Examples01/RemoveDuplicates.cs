using System.Text;

namespace String_Examples01
{
    public static class RemoveDuplicates
    {
        public static string RemoveDuplicatesByCharacter(string input)
        {
            var output = new StringBuilder();
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                var found = false;
                for (int j = 0; j < output.Length; j++)
                {
                    if (arr[i] == output[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    output.Append(arr[i]);
                }
            }
            return output.ToString();
        }

        public static string RemoveDuplicatesByHashSet(string input)
        {
            var output = new StringBuilder();
            var hashSet = new HashSet<char>();
            foreach (var ch in input)
            {
                if (hashSet.Add(ch))
                {
                    output.Append(ch);
                }
            }

            return output.ToString();
        }

        public static string RemoveDuplicatesByDictoinary(string input)
        {
            var output = new StringBuilder();
            var dict = new Dictionary<char, bool>();
            foreach(char ch in input)
            {
                if(!dict.ContainsKey(ch))
                {
                    dict.Add(ch, true);
                    output.Append(ch);
                }
            }

            return output.ToString().Trim();
        }

        public static string RemoveDuplicatesByLinq(string input)
        {
            return new string(input.Distinct().ToArray());
        }
    }
}
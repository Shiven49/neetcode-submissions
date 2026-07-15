public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> save = new();

        foreach (string word in strs) {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!save.ContainsKey(key))
                save[key] = new List<string>();

            save[key].Add(word);
        }

        return save.Values.ToList();
    }
}
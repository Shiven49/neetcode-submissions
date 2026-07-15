public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs){
            int len= s.Length;
            sb.Append(len);
            sb.Append("#");
            sb.Append(s);
            }
        string coded = sb.ToString();
        return coded;

    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i<s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
                }

                int length = int.Parse(s.Substring(i,j-i));
                result.Add(s.Substring(j+1,length));
                i=j+1+length;
            }
        
        return result;

   }
}

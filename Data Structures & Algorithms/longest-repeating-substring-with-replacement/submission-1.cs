public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq= new int[26];
        int l=0;
        int maxf=0;
        int len=0;
        for(int r=0;r<s.Length;r++){
            freq[s[r]-'A']++;
            maxf=Math.Max(maxf,freq[s[r]-'A']);
            while(r-l+1-maxf> k){
                freq[s[l]-'A']--;
                l++;
            }
        
        len=Math.Max(len,r-l+1);}
        return len;
    }
}

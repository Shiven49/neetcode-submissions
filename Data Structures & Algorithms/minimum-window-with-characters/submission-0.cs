public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length<t.Length){
            return "";
        }
        else{
            int[] need=new int[128];
            int[] window=new int[128];
            int count=0; 
            int needCount = 0;

        foreach (char c in t) {

            if (need[c] == 0)

                needCount++;

            need[c]++;

        }

        int have = 0;

        int l = 0;

        int minLen = int.MaxValue;

        int start = 0;

        for (int r = 0; r < s.Length; r++) {

            char c = s[r];

            window[c]++;

            if (need[c] > 0 && window[c] == need[c])

                have++;

            while (have == needCount) {

                if (r - l + 1 < minLen) {

                    minLen = r - l + 1;

                    start = l;

                }

                char leftChar = s[l];

                window[leftChar]--;

                if (need[leftChar] > 0 && window[leftChar] < need[leftChar])

                    have--;

                l++;

            }

        }

        if (minLen == int.MaxValue)

            return "";

        return s.Substring(start, minLen);
            }
        }
    }


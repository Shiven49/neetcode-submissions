public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }
        else{
            int[] count1=new int[26];
            int[] count2=new int[26];
            for (int i = 0; i < s1.Length; i++) {
            count1[s1[i] - 'a']++;
            count2[s2[i] - 'a']++;

        }
        bool same = true;

        for (int i = 0; i < 26; i++) {

            if (count1[i] != count2[i]) {

                same = false;

                break;

            }

        }

        if (same)

            return true;

        

        for (int r = s1.Length; r < s2.Length; r++) {

            count2[s2[r] - 'a']++;                  

            count2[s2[r - s1.Length] - 'a']--;      

            same = true;

            for (int i = 0; i < 26; i++) {

                if (count1[i] != count2[i]) {

                    same = false;

                    break;

                }

            }

            if (same)

                return true;

        }

        return false;


                
            }

        }
    }


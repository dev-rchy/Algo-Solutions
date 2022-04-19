
//Best
public class Solution {
    public int MostWordsFound(string[] sentences) {
        return sentences.Select(s => s.Split(' ').Count()).Max();
    }
}

//Brute Force
public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxWord = 0;
        
        for(int i = 0;i<sentences.Length;i++) {
            string a =  sentences[i];
            int count = 1;
            for(int j = 0; j<a.Length;j++) {
            if(Char.IsWhiteSpace(a[j])) {
                count++;
               }
            }
            if(maxWord<count)
            maxWord = count;
        }
        return maxWord;
    }
}
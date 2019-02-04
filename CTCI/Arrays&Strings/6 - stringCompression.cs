//Note: In-place solution on leetcode
public string Compress(string s)
{
    StringBuilder compressed = new StringBuilder();
    int countConsecutive = 0;

    for (int i = 0; i < s.Length; i++) 
    {
        countConsecutive++;

        //check next character
        if (i + 1 >= s.Length || s[i] != s[i + 1])
        {
            compressed.Append(s[i]);
            compressed.Append(countConsecutive);
            countConsecutive = 0;
        }
    }

    return compressed.Length < s.Length ? compressed.ToString() : s;
}

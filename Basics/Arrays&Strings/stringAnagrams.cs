public bool IsAnagram(string s, string t)
{
    int len1 = s.Length;
    int len2 = t.Length;

    //edge case
    if (len1 > len2 || len2 > len1)
        return false;

    int[] track1 = new int[26];
    int[] track2 = new int[26];

    //string1
    for (int i = 0; i < len1; i++)
    {
        track1[s[i] - 'a'] += 1;
    }

    //string2
    for (int i = 0; i < len2; i++)
    {
        track2[t[i] - 'a'] += 1;
    }

    //compare track1 and track2
    for (int i = 0; i < 26; i++)
    {
        if (track1[i] != track2[i])
            return false;
    }

    return true;
}

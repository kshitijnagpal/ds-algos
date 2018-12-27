public int FirstUniqChar(string s)
{
    int length = s.Length;

    //track character frequency
    int[] track = new int[256];

    //traversing the string
    for (int i = 0; i < length; i++)
    {
        track[s[i]] += 1;
    }

    for (int j = 0; j < length; j++)
    {
        if (track[s[j]] == 1)
        {
            return j;
        }
    }

    return -1;
}

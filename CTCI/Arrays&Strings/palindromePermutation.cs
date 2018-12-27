public bool CanPermutePalindrome(string s)
{
    Dictionary<char, int> map = new Dictionary<char, int>();
    int count = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (map.ContainsKey(s[i]))
        {
            map[s[i]] += 1;
        }
        else
        {
            map[s[i]] = 1;
        }
    }

    foreach (var key in map.Keys)
    {
        count = count + map[key] % 2;
    }

    return count <= 1;
}

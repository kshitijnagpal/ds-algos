//Standard character set- 128 characters
//ASCII extended set – 256 characters
public bool isUnique(string s)
{
    bool[] char_set = new bool[256];

    for (int i = 0; i < s.Length; i++)
    {
        if (char_set[s[i]])
        {
            return false;
        }
        else
        {
            char_set[s[i]] = true;
        }
    }

    return true;
}

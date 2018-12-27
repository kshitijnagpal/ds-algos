//helper
public string sort(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Sort(charArray);

    return new String(charArray);
}

public bool checkPermutation(string s, string t)
{
    if (s.Length != t.Length)
        return false;
    return sort(s).Equals(sort(t));
}

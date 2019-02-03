//ASCII values
// a - 97
// A - 65

//C++ implementation

string upperToLower(string str)
{
    while (str)
    {
        if (lowerCase[i] >= 'A' && lowerCase[i] <= 'Z')
        {
            str[i] = str[i] + 32;
        }
    }

    return str;
}

//C# implementation
string upperToLower(string str)
{
    //Kshitij to kshitij
    int length = str.Length;
    int i = 0;

    StringBuilder finalStr = new StringBuilder();

    while (i < length)
    {
        if (str[i] >= 'A' && str[i] <= 'Z')
        {
            finalStr.Append((char)(str[i] + 32));
        }

        i++;
    }

    return finalStr.ToString();
}

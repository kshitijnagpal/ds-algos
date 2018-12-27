//Input: "Let's take LeetCode contest"
//Output: "s'teL ekat edoCteeL tsetnoc"

//helper
string reverse(string str, int start, int end)
{
    char temp;

    while (start < end)
    {
        temp = str[start];
        str[start] = str[end];
        str[end] = temp;

        start++;
        end--;
    }

    return str;
}

string reverseWords(string str)
{
    int start = 0;
    int temp = 0;

    while (str[temp])
    {
        temp++;
        if (str[temp] == ' ' || temp == str.length())
        {
            str = reverse(str, start, temp - 1);
            start = temp + 1;
        }
    }

    return str;
}

//Note: Check leetcode for other variations of this problem!

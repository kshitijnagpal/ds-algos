int myAtoi(string str)
{
    int i = 0, isNeg = 0, num = 0, sign = 1, result = 0;

    int length = str.Length;
    int backup;

    //ignore whitespaces
    while (i < length && str[i] == ' ')
    {
        i++;
    }

    //check for plus sign
    if (i < length && str[i] == '+')
    {
        i++;
    }
    else if (i < length && str[i] == '-')
    {
        sign = -1;
        i++;
    }

    //using isdigit to check for non-digit characters - "4193 with words"
    while (i<length && Char.IsNumber(str[i]))
    {
        backup = num;
        num = num * 10 + (str[i] - '0');//ASCII Value of '0' is 48

        //check for overflow!!!
        if (num < 0 || backup != (num - (str[i] - '0')) / 10)
        {
            return sign == 1 ? Int32.MaxValue : Int32.MinValue;
        }

        i++;
    }

    return num * sign;
}

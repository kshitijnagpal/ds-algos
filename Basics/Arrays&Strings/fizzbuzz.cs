public IList<string> FizzBuzz(int n) {
    IList<string> result = new List<string>();

    for (int i = 1; i <= n; i++)
    {
        //multiples of 3 and 5
        if (i % 3 == 0 && i % 5 == 0)
            result.Add("FizzBuzz");

        //multiples of 3
        else if (i % 3 == 0)
            result.Add("Fizz");

        //multiples of 5
        else if (i % 5 == 0)
            result.Add("Buzz");

        //multiples of neither 3 nor 5
        else if (i % 3 != 0 && i % 5 != 0)
            result.Add(i.ToString());

    }

    return result;
}

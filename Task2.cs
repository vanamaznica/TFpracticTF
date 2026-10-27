using System;

interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}

class Array : IMath
{
    int[] numbers;

    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }

    public int Max()
    {
        int max = numbers[0];
        foreach (int n in numbers)
            if (n > max)
                max = n;
        return max;
    }

    public int Min()
    {
        int min = numbers[0];
        foreach (int n in numbers)
            if (n < min)
                min = n;
        return min;
    }

    public float Avg()
    {
        int sum = 0;
        foreach (int n in numbers)
            sum += n;
        return (float)sum / numbers.Length;
    }

    public bool Search(int valueToSearch)
    {
        foreach (int n in numbers)
            if (n == valueToSearch)
                return true;
        return false;
    }
}

class Program
{
    static void Main()
    {
        Array arr = new Array(new int[] { 5, 2, 8, 1, 4 });
        Console.WriteLine(arr.Max());
        Console.WriteLine(arr.Min());
        Console.WriteLine(arr.Avg());
        Console.WriteLine(arr.Search(8));
    }
}
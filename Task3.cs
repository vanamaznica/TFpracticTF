using System;

interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

class Array : ISort
{
    int[] numbers;

    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }

    public void SortAsc()
    {
        System.Array.Sort(numbers);
    }

    public void SortDesc()
    {
        System.Array.Sort(numbers);
        System.Array.Reverse(numbers);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
            SortAsc();
        else
            SortDesc();
    }

    public void Show()
    {
        foreach (int n in numbers)
            Console.Write(n + " ");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Array arr = new Array(new int[] { 5, 2, 8, 1, 4 });

        arr.SortAsc();
        arr.Show();
        arr.SortDesc();
        arr.Show();
        arr.SortByParam(true);
        arr.Show();
    }
}
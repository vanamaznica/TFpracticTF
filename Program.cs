using System;
interface IOutput
{
    void Show();
    void Show(string info);
}

class Array : IOutput
{
    int[] numbers;

    public Array(int[] numbers)
    {
        this.numbers = numbers;
    }

    public void Show()
    {
        foreach (int n in numbers)
            Console.Write(n + " ");
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine(info);
        Show();
    }
}
class Program
{
    static void Main()
    {
        Array arr = new Array(new int[] { 1, 2, 3, 4, 5 });
        arr.Show();
        arr.Show("My array:");
    }
}
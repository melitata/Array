using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Lütfen 10 adet tam sayı girin:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nGirilen sayılar:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.Write("\n11. sayı olarak bir tam sayı girin: ");
        int newNumber = Convert.ToInt32(Console.ReadLine());
        int[] extendedNumbers = new int[numbers.Length + 1];
        numbers.CopyTo(extendedNumbers, 0);
        extendedNumbers[10] = newNumber; 
        Array.Sort(extendedNumbers);
        Array.Reverse(extendedNumbers); 
        Console.WriteLine("\nBüyükten küçüğe sıralanmış sayılar:");
        foreach (int number in extendedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

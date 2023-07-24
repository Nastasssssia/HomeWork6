namespace MyLib;
public static class MyLibClass
{
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());

    }
    public static int[] InputArray(int length)
    {
        int[]array = new int [length];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Input($"Введите {i +1}-й элемент:");
        }
        return array;
    }
    public static void PrintArray(int[]array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}");
        }

    }

    public static int CountPositive(int[]array)
    {
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0) count++;
        }
        return count;
    }
    
}
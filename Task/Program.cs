using MyLib;
namespace Task;
class Program
{
    static void Main(string[] args)
    {
        void Task41()
        {
            // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            int length = MyLibClass.Input("Введите количество цифр:");
            int countPositive = 0;
            for(int i =0; i < length; i++)
            {
                int number = MyLibClass.Input($"Введите число {i + 1}:");
                if(number > 0) countPositive++;
            }
            Console.WriteLine($" Количество чисел больше 0: {countPositive}");

        }
        
        void Task41var()
        {
            int length = MyLibClass.Input("Введите количество цифр:");
            int[]array = MyLibClass.InputArray(length);
            MyLibClass.PrintArray(array);
            Console.WriteLine($"Количество чисел больше 0 - {MyLibClass.CountPositive(array)}");
        }
        void Task43()
        {
            //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
            /// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            int k1 = MyLibClass.Input("Введите значение числа k1:");  // kx1 + b1 = kx2 +b2
            int k2 = MyLibClass.Input("Введите значение числа k2:");  // k1x - k2x = b2 - b1 // x(k1-k2)= b2 - b1
            int b1 = MyLibClass.Input("Введите значение числа b1:");  // x = (b2 - b1) / (k1-k2) 
            int b2 = MyLibClass.Input("Введите значение числа b2:");
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения:x={x}, y = {y}");
        }

        
    }
}

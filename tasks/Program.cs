using MyLib;
namespace tasks;

class Program
{
    static void Main(string[] args)
    {

        //         Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
        //         который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        // M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"

        void Task64()
        {
            int Recursion(int M, int N, int result = 0)
            {
                if (M > N)
                {
                    return result;
                }
                
                if (M % 3 == 0)
                {
                    result = M;
                    Console.Write($"{result}, ");
                }
                M++;
                return Recursion(M, N, result);
            }


            int number1 = MyLibClass.Input("Введите число M: ");
            int number2 = MyLibClass.Input("Введите число N: ");
            Console.Write($"числа в промежутке от {number1} до {number2} кратные 3-ем: ");
            Recursion(number1,number2);
            Console.Write("\b\b  ");

            // int result = 0;
            // Console.Write($"числа в промежутке от {number1} до {number2} кратные 3-ем: ");
            // for (int i = number1; i <= number2; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         result = i;
            //         Console.Write($"{result}, ");
            //     }
            // }
            // Console.Write("\b\b  ");

        }

        Task64();

        // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
        // который найдёт сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30


        void Task66()
        {

        }

        Task66();

        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        // Даны два неотрицательных числа m и n.
        // m = 3, n = 2 -> A(m,n) = 29


        void Task68()
        {

        }

        Task68();

    }
}

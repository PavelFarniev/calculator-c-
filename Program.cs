using System;

namespace calculator
{
    class Program
    {
        static float memory = 0;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор");
            Console.WriteLine("Можно: +, -, *, /, %, квадрат (pow), корень (sqrt)");
            Console.WriteLine("Память: M+ (запомнить), M- (стереть), MR (взять)");
            
            bool working = true;
            
            while (working)
            {
                // Первое число
                Console.Write("Первое число (или MR): ");
                string input1 = Console.ReadLine();
                float num1;
                
                if (input1.ToUpper() == "MR")
                {
                    num1 = memory;
                    Console.WriteLine("Взято из памяти: " + num1);
                }
                else
                {
                    num1 = float.Parse(input1);
                }
                
                // Операция
                Console.Write("Операция: ");
                string op = Console.ReadLine();
                
                float num2 = 0;
                // Если нужно второе число
                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%")
                {
                    Console.Write("Второе число (или MR): ");
                    string input2 = Console.ReadLine();
                    
                    if (input2.ToUpper() == "MR")
                    {
                        num2 = memory;
                        Console.WriteLine("Взято из памяти: " + num2);
                    }
                    else
                    {
                        num2 = float.Parse(input2);
                    }
                }
                
                // Вычисления
                float result = 0;
                bool ok = true;
                
                if (op == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + result);
                }
                else if (op == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + result);
                }
                else if (op == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + result);
                }
                else if (op == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Нельзя делить на ноль!");
                        ok = false;
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                    }
                }
                else if (op == "%")
                {
                    result = num1 % num2;
                    Console.WriteLine(num1 + " % " + num2 + " = " + result);
                }
                else if (op == "pow")
                {
                    result = num1 * num1;
                    Console.WriteLine(num1 + " в квадрате = " + result);
                }
                else if (op == "sqrt")
                {
                    if (num1 < 0)
                    {
                        Console.WriteLine("Нельзя взять корень из отрицательного!");
                        ok = false;
                    }
                    else
                    {
                        result = (float)Math.Sqrt(num1);
                        Console.WriteLine("Корень из " + num1 + " = " + result);
                    }
                }
                else if (op == "M+")
                {
                    memory += num1;
                    Console.WriteLine("Запомнили: " + memory);
                }
                else if (op == "M-")
                {
                    memory -= num1;
                    Console.WriteLine("Стерли из памяти: " + memory);
                }
                else
                {
                    Console.WriteLine("Не знаю такую операцию");
                    ok = false;
                }
                
                if (ok)
                {
                    Console.WriteLine("Успешно!");
                }
                
                Console.WriteLine("---");
                Console.Write("Еще раз? (да/нет): ");
                string answer = Console.ReadLine();
                
                if (answer.ToLower() != "да")
                {
                    working = false;
                }
            }
            
            Console.WriteLine("Пока! Память: " + memory);
            Console.ReadKey();
        }
    }
}
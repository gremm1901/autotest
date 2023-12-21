using System;
class Сalculator
{
    static string[] functionsText = { "сумма", "вычитание", "умнажение", "деление", "факториал","степень" , "выход" };


    static void Main()
    {
        Console.WriteLine($"введите что хотите сделать : ");

        int arrLengt = functionsText.Length;
        for (int i = 0; i < arrLengt; i++)
        {
            Console.WriteLine($"{functionsText[i]}");
        }

        string? nameFunction = Console.ReadLine();

        if (nameFunction == functionsText[^1])
        {
            Exit();
        }
        else if (nameFunction == null | nameFunction == "")
        {
            Console.WriteLine("Если бы мы понимали что это такое, но мы не понимаем что это такое.Давай все поновой :( \n");
            Main();
        }
        else
        {
            Input(nameFunction);
            Main();
        }
    }

    public static void Exit() { 
        Console.Write("досвидание");
    }

    public static void Input (string nameFunction) 
    {
        if (nameFunction == functionsText[^3])
        {
            Console.Write("Введите число:");
            string? oneValues = Console.ReadLine();
            double res = Factorial(IsNumber(oneValues));

            Console.WriteLine($"{nameFunction} = {res}");
        }
        else if (nameFunction == functionsText[^2])
        {
            Console.Write("Введите число:");
            string? oneValues = Console.ReadLine();

            Console.Write("Введите степень числа:");
            string? twoValues = Console.ReadLine();

            double[] values = { IsNumber(oneValues), IsNumber(twoValues) };
            var res = Functions(nameFunction, values);
            Console.WriteLine($"{nameFunction} = {res}");
        }
        else
        {
            Console.Write("Введите первое число:");
            string? oneValues = Console.ReadLine();

            Console.Write("Введите второе число:");
            string? twoValues = Console.ReadLine();

            double[] values = { IsNumber(oneValues), IsNumber(twoValues) };
            var res = Functions(nameFunction, values);
            Console.WriteLine($"{nameFunction} = {res}");
        }
    }
    public static int IsNumber(string num) 
    {
        bool number = int.TryParse(num, out int numberOut);
        if (number)
        {
            return numberOut;
        }
        else 
        {
        Console.WriteLine("Давай поновой");
            string? oneValues = Console.ReadLine();
            return IsNumber(oneValues);
        }
    }

    public static object Functions(string nameFunction, double[] values)
    {

        switch (nameFunction)
        {
            case "сумма": return Summa(values);
            case "вычитание": return Deduction(values);
            case "умнажение": return Multiplication(values);
            case "деление": return Division(values);
            case "степень": return Degree(values);
            default: return "Все фигня давай поновой";
        }
    }

    public static double Summa(double[] values)
    {
        double summ = 0;
        for (int i = 0; i < values.Length; i++)
        {
            summ += values[i];
        }
        return summ;
    }

    public static double Factorial(double oneValues)
    {
        if (oneValues == 1) return 1;
        return oneValues * Factorial(oneValues-1);
    }

    public static double Degree(double[] oneValues)
    {
        double summ = 1;
        if (oneValues[1] == 0) return 1;
        for (int i = 0; i < oneValues[1]; i++)
        {
            summ = summ* oneValues[0];
        }
        return summ;
    }

    public static double Deduction(double[] values)
    {
        double summ = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            summ -= values[i];
        }
        return summ;
    }

    public static double Multiplication(double[] values)
    {
        double summ = 0;
        for (int i = 0; i < values.Length; i++)
        {
            summ *= values[i];
        }
        return summ;
    }

    public static object Division(double[] values)
    {
        double summ = values[0];
        if (values[0] == 0)
        {
            summ = 0;
        }
        else if (values[1] == 0)
        {
            return "нельзя делить на ноль";
        }
        else
        {
            for (int i = 1; i < values.Length; i++)
            {
                summ /= values[i];
            }
        }
        return summ;
    }
} 
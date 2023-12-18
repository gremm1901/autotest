using System;
class Сalculator
{

    static void Main()
    {
        string[] functionsText = { "сумма", "вычитание", "умнажение", "деление" , "выход"};
        Console.WriteLine($"введите что хотите сделать : {functionsText[0]}, {functionsText[1]}, {functionsText[2]}, {functionsText[3]}");
        string? nameFunction = Console.ReadLine();

        Console.Write("Введите первое число:");
        double oneValues = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число:");
        double twoValues = Convert.ToDouble(Console.ReadLine());

        double[] values = { oneValues, twoValues };


        object res = Functions(nameFunction, values );
        
        Console.WriteLine($"{nameFunction} = {res}");
            
        if (nameFunction != functionsText[4])
        {
            Main();
        }
        else { }
    }
    public static object Functions(string nameFunction, double[] values)
    {

        switch (nameFunction)
        {
            case "сумма": return Summa(values);
            case "вычитание": return Deduction(values);
            case "умнажение": return Multiplication(values);
            case "деление": return Division(values);
            default: return "Все фигня давай поновой";
        }
    }
    public static double Summa(double[] values)
    {
        int arrLengt = values.Length;
        double summ = 0;
        for (int i = 0; i < arrLengt; i++)
        {
            summ += values[i];
        }
        return summ;
    }
    public static double Deduction(double[] values)
    {
        int arrLengt = values.Length;
        double summ = values[0];
        for (int i = 1; i < arrLengt; i++)
        {
            summ -= values[i];
        }
        return summ;
    }
    public static double Multiplication(double[] values)
    {
        int arrLengt = values.Length;
        double summ = 0;
        for (int i = 0; i < arrLengt; i++)
        {
            summ *= values[i];
        }
        return summ;
    }
    public static object Division(double[] values)
    {
        int arrLengt = values.Length;
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
            for (int i = 1; i < arrLengt; i++)
            {
                summ /= values[i];
            }
        }
        return summ;
    }
}




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


        double res = Functions(nameFunction, values );
        if (nameFunction != functionsText[0] && nameFunction != functionsText[1] && nameFunction != functionsText[2] && nameFunction != functionsText[3]) 
        { 
            Console.WriteLine("Все фигня давай поновой"); 
        } else { 
            Console.WriteLine($"{nameFunction} = {res}");
            }
        if (nameFunction != functionsText[4])
        {
            Main();
        }
        else { }
    }
    public static double Functions(string nameFunction, double[] values)
    {

        switch (nameFunction)
        {
            case "сумма": return Summa(values);
            case "вычитание": return Deduction(values);
            case "умнажение": return Multiplication(values);
            case "деление": return Division(values);
            default: return 0;
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
        double summ = 0;
        for (int i = 0; i < arrLengt; i++)
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
    public static double Division(double[] values)
    {
        int arrLengt = values.Length;
        double summ = 0;
        for (int i = 0; i < arrLengt; i++)
        {
            summ /= values[i];
        }
        return summ;
    }
}




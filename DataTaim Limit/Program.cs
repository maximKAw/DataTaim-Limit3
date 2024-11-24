using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите дату в формате 'дд месяц гггг' для метода Parse:");
        string put1 = Console.ReadLine();
        
        ParseDateUsingParse(put1);

        Console.WriteLine("\nВведите дату в формате 'дд-MM-гггг' для метода ParseExact:");
        string put2 = Console.ReadLine();
        ParseDateUsingParseExact(put2);

        Console.WriteLine("\nВведите дату в формате 'дд месяц гггг' для метода TryParse:");
        string put3 = Console.ReadLine();
        TryParseDate(put3);

        Console.WriteLine("\nВведите дату в формате 'дд-MM-гггг' для метода TryParseExact:");
        string put4 = Console.ReadLine();
        TryParseExactDate(put4);
        // Задал для этих четырех методов стринги
        // Прописываем текст, далее мы начнем переходить к самим методам
    }

    public static void ParseDateUsingParse(string dateString)
    {
        try
        {
            DateTime date = DateTime.Parse(dateString);
            Console.WriteLine("Parsed date using Parse: " + date.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("ru-RU")));
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты для метода Parse.");
        }
    }

    
    public static void ParseDateUsingParseExact(string dateString)
    {
        string format = "dd-MM-yyyy";
        try
        {
            DateTime date = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Parsed date using ParseExact: " + date.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("ru-RU")));
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный формат даты для метода ParseExact.");
        }
    }

    public static void TryParseDate(string dateString)
    {
        DateTime date;
        if (DateTime.TryParse(dateString, out date))
        {
            Console.WriteLine("Parsed date using TryParse: " + date.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("ru-RU")));
        }
        else
        {
            Console.WriteLine("Неверный формат даты для метода TryParse.");
        }
    }

    public static void TryParseExactDate(string dateString)
    {
        string format = "dd-MM-yyyy";
        DateTime date;
        if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
        {
            Console.WriteLine("Parsed date using TryParseExact: " + date.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("ru-RU")));
        }
        else
        {
            Console.WriteLine("Неверный формат даты для метода TryParseExact.");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("#1");
        int number = 17;
        int tens = number / 10;
        int units = number % 10;

        if (tens == 4 || tens == 7 || units == 4 || units == 7)
        {
            Console.WriteLine("7 || 4");
        }
        else if (tens == 3 || tens == 6 || tens == 9 || units == 3 || units == 6 || units == 9)
        {
            Console.WriteLine("3 || 6 || 9");
        }

        Console.WriteLine("#2");
        int n = 5559;
        string numStr = n.ToString();

        if (numStr.GroupBy(c => c).Any(g => g.Count() == 3))
        {
            Console.WriteLine("число содержит 3 одинаковые цифры");
        }

        Console.WriteLine("#3");
        double a = 245.453;
        double b = 876.23;
        double c = -4576.32;
        double d = 463.7;

        int negativeCount = (a < 0 ? 1 : 0) + (b < 0 ? 1 : 0) + (c < 0 ? 1 : 0) + (d < 0 ? 1 : 0);
        if (negativeCount != 0)
        {
            Console.WriteLine($"{negativeCount} из 4 отрицательные");
        }

        Console.WriteLine("#4");
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Корни: {x1}, {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Единственный корень: {x}");
        }
        else
        {
            Console.WriteLine("Вещественных корней нет");
        }

        Console.WriteLine("#5");
        double a1 = 534.65;
        double b1 = 23.465;
        double c1 = 65.875;
        double a2 = 6578.54;
        double b2 = 1.1;
        double c2 = 87.6;

        double mean1 = (new[] { a1, b1, c1 }).OrderBy(x => x).Skip(1).First();
        double mean2 = (new[] { a2, b2, c2 }).OrderBy(x => x).Skip(1).First();

        double finalMean = (mean1 + mean2) / 2;

        Console.WriteLine("#6");
        int dayNumber = 5;

        switch (dayNumber)
        {
            case 1: Console.WriteLine("Понедельник"); break;
            case 2: Console.WriteLine("Вторник"); break;
            case 3: Console.WriteLine("Среда"); break;
            case 4: Console.WriteLine("Четверг"); break;
            case 5: Console.WriteLine("Пятница"); break;
            case 6: Console.WriteLine("Суббота"); break;
            case 7: Console.WriteLine("Воскресенье"); break;
            default: Console.WriteLine("Некорректный номер дня"); break;
        }

        Console.WriteLine("#7");
        int monthNumber = 4;

        switch (monthNumber)
        {
            case 12: case 1: case 2: Console.WriteLine("Зима"); break;
            case 3: case 4: case 5: Console.WriteLine("Весна"); break;
            case 6: case 7: case 8: Console.WriteLine("Лето"); break;
            case 9: case 10: case 11: Console.WriteLine("Осень"); break;
            default: Console.WriteLine("Некорректный номер месяца"); break;
        }

        Console.WriteLine("#8");
        int birthYear = 2001;
        int birthMonth = 11;
        int birthDay = 8;
        int currentYear = 2025;
        int currentMonth = 2;
        int currentDay = 12;

        int age = currentYear - birthYear;
        if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
        {
            age--;
        }

        Console.WriteLine($"Возраст: {age} полных лет");

        Console.WriteLine("#9");
        int a3 = 12;
        int b3 = 4;
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 10; i <= b; i++)
        {
            Console.WriteLine(i * i);
        }
        for (int i = a3; i <= 50; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
        for (int i = a3; i >= b3; i--)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine("#10");
        double R = 6370;
        for (double h = 1; h <= 10; h++)
        {
            double distance = Math.Sqrt(2 * R * h + h * h);
            Console.WriteLine($"Высота: {h} км, Расстояние до горизонта: {distance:F2} км");
        }

    }
}
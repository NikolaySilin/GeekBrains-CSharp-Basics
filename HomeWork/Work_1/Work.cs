namespace HomeWork.Work_1;

public class Work
{
    static void Main(string[] args)
    {
        //Questionnaire();
        //CalculationOfBodyMassIndex();
        //DistanceCalculationBetweenPoints();
        //ValueExchange();
        CenterOutput();
    }

    # region [ Задание 1. Анкета ]
    private static void Questionnaire()
    {
        Console.Write("Введите ваше Имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите вашу Фамилию: ");
        string surname = Console.ReadLine();
        
        Console.Write("Введите ваш Возвраст: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Введите ваш Рост: ");
        int growth = int.Parse(Console.ReadLine());
        
        Console.Write("Введите ваш Вес: ");
        int weight = int.Parse(Console.ReadLine());

        Console.WriteLine("Имя: " + name + " | Фамилия: " + surname + " | Возраст: " + age + " | Рост: " + growth + " | Вес: " + weight);

        Console.WriteLine("Имя: {0} | Фамилия: {1} | Возраст: {2} | Рост: {3} | Вес: {4} ", name, surname, age, growth, weight);

        Console.WriteLine($"Имя: {name} | Фамилия: {surname} | Возраст: {age} | Рост: {growth} | Вес: {weight}");
    }
    #endregion

    # region [ Задание 2. Рассчет ИМТ ]
    private static void CalculationOfBodyMassIndex()
    {
        Console.Write("Введите свой Вес: ");
        int weight = int.Parse(Console.ReadLine());
        
        Console.Write("Введите свой Рост: ");
        float growth = float.Parse(Console.ReadLine());

        float bmi = weight / (growth * growth);

        Console.WriteLine($"Ваш индекс массы тела: {bmi}");
    }
    #endregion

    # region [ Задание 3. Расчет расстояния между точками ]
    private static void DistanceCalculationBetweenPoints()
    {
        Console.Write("Введите первую координату первой точки: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Введите вторую координату первой точки: ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("\nВведите первую координату второй точки: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Введите вторую координату второй точки: ");
        int y2 = int.Parse(Console.ReadLine());

        double distanceCalc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Дистанция между двумя точками: {distanceCalc:F2}");
    }
    #endregion

    # region [ Задание 4. Обмен значений ]
    private static void ValueExchange()
    {
        Console.Write("Введите первое любое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write($"Первое число = {a}");

        Console.Write("\nВведите второе любое число: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write($"Второе число = {b}");

        Console.WriteLine("\n\nОбмен значений!");
        
        int c = b;
        b = a;
        a = c;
        
        Console.Write($"\nПервое число = {a}");
        Console.Write($"\nВторое число = {b}");
    }
    #endregion
    
    # region [ Задание 5, вывод в центре экрана. ]
    private static void CenterOutput()
    {
        Console.Write("Введите ваше Имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите вашу Фамилию: ");
        string surname = Console.ReadLine();
        Console.Write("Введите ваш город проживания: ");
        string city = Console.ReadLine();

        string info = name + " " + surname + ", " + city;

        int width = Console.WindowWidth;
        int indent = width / 2 + info.Length / 2;
        Console.WriteLine("{0," + indent + "}", info);
    }
    #endregion
}
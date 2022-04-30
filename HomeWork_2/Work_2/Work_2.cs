namespace ConsoleApp1.Work_2;

public class Work_2
{
    static void Main(string[] args)
    {
        ChooseYourDestiny();
    }
    
    # region [ Switch case ]
    private static void ChooseYourDestiny()
    {
        Console.Write("Выберите задание для проверки, от 1 до 5: ");
        
        int number = int.Parse(Console.ReadLine());
        
        string message = $"\nВы выбрали для проверки задание: {number}";

        switch (number)
        {
            case 1:
                Console.WriteLine(message);
                MinimumOfThree();
                break;
            case 2:
                Console.WriteLine(message);
                CountingNumbers();
                break;
            case 3:
                Console.WriteLine(message);
                PositiveOddNumbers();
                break;
            case 4:
                Console.WriteLine(message);
                Authorization();
                break;
            case 5:
                Console.WriteLine(message);
                CalculationBMI();
                break;
            default:
                Console.WriteLine("Задания с таким номером нету!");
                break;
        }
    }
    #endregion
    
    # region [ Задание 1. Минимальное число из трех ]
    private static void MinimumOfThree()
    {
        int min;
        Console.WriteLine("\nПрограмма подсчета минимального числа из трех чисел");
        
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("Введите третье число: ");
        int с = int.Parse(Console.ReadLine());

        min = a;
        if (b < min) min = b;
        if (с < min) min = с;
        
        Console.WriteLine($"Минимальное число из трех: {min}");
    }
    #endregion
    
    # region [ Задание 2. Подсчет количества цифр числа ]
    private static void CountingNumbers()
    {
        Console.WriteLine("\nПрограмма подсчета количества цифр в числе.");
        
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        while (number > 0)
        {
            count++;
            number /= 10;
        }
        
        Console.WriteLine($"Количество цифр в числе: {count}");
    }
    #endregion
    
    # region [ Задание 3. Сумма всех введенных положительных нечетных чисел ]
    private static void PositiveOddNumbers()
    {
        Console.WriteLine("\nПрограмма подсчета суммы всех введенных с клавиатуры, положительных нечетных чисел.");
        
        int sum = 0;
        int number;

        do
        {
            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());
            if (number > 0 && number % 2 == 1)
            {
                sum += number;
            }
        } while (number != 0);

        Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");
    }
    #endregion
    
    # region [ Задание 4. Авторизация по логину и паролю ]
    private static void Authorization()
    {
        Console.WriteLine("\nПрограмма проверки валидации логина и пароля.");
        
        string loginAccount = "root";
        string passwordAccount = "GeekBrains";

        int numberOfAttempts = 3;

        do
        { 
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();
        
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();
        
            if (login.Contains(loginAccount) && password.Contains(passwordAccount) && loginAccount.Contains(login) && passwordAccount.Contains(password))
            {
                Console.WriteLine("Авторизация прошла успешно!");
                break;
            }
            else
            {
                numberOfAttempts--;
                Console.WriteLine("Неверный логин или пароль, попробуйте снова!");
                Console.WriteLine($"Количество попыток: {numberOfAttempts}\n");
            }
        } while (numberOfAttempts > 0);
    }
    #endregion
    
    # region [ Задание 5. Программа рассчета массы тела ]
    private static void CalculationBMI()
    {
        Console.WriteLine("\nПрограмма расчета индекса массы тела.");
        
        double resultIMT = 0;
        double optimalWeight = 0;
        
        double indexMass_max = 24.99;
        double indexMass_min = 18.4;

        Console.Write("Введите ваш вес (в киллограммах): ");
        int weight = int.Parse(Console.ReadLine());
        
        Console.Write("Введите ваш рост (в метрах): ");
        float height = float.Parse(Console.ReadLine());
        
        float bmi = weight / (height * height);

        Console.WriteLine($"\nВаш индекс массы тела: {bmi}");
        
        if (bmi > 40 && bmi < 45)
        {
            optimalWeight = indexMass_max * (height * height);
            resultIMT = Math.Abs(weight - optimalWeight);
            Console.WriteLine("У вас ожирение третей степени");
            Console.WriteLine($"Вам следует похудеть на {resultIMT:F2} килограмма");
        }
        else if (bmi > 35 && bmi < 40)
        {
            optimalWeight = indexMass_max * (height * height);
            resultIMT = Math.Abs(weight - optimalWeight);
            Console.WriteLine("У вас ожирение второй степени");
            Console.WriteLine($"Вам следует похудеть на {resultIMT:F2} килограмма");
        }
        else if (bmi > 30 && bmi < 35)
        {
            optimalWeight = indexMass_max * (height * height);
            resultIMT = Math.Abs(weight - optimalWeight);
            Console.WriteLine("У вас ожирение первой степени");
            Console.WriteLine($"Вам следует похудеть на {resultIMT:F2} килограмма");
        }
        else if (bmi > 25 && bmi < 30)
        {
            optimalWeight = indexMass_max * (height * height);
            resultIMT = Math.Abs(weight - optimalWeight);
            Console.WriteLine("У вас избыточная масса тела (предожирение)");
            Console.WriteLine($"Вам следует похудеть на {resultIMT:F2} килограмма");
        }
        else if (bmi > 18.5 && bmi < 25)
        {
            Console.WriteLine("Ваш вес тела в норме)");
        }
        else if (bmi > 16 && bmi < 18.5)
        {
            optimalWeight = indexMass_min * (height * height);
            resultIMT = Math.Abs(weight - optimalWeight);
            Console.WriteLine("У вас недостаточная (дефицит) масса тела");
            Console.WriteLine($"Вам следует поправится на {resultIMT:F2} килограмма");
        }
        else if (bmi <= 16)
        {
            optimalWeight = indexMass_min * (height * height);
            resultIMT = Math.Abs(weight - optimalWeight);
            Console.WriteLine("У вас выраженный дефицит массы тела");
            Console.WriteLine($"Вам следует поправится на {resultIMT:F2} килограмма");
        }
    }
    #endregion
}
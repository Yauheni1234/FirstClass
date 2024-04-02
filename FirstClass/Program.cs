// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Урок 3
//Задание 1

var cal = "Консольный калькулятор";
Console.WriteLine(cal);
int operand1 = 5;
int operand2 = 6;
string cal2 = "Ввести знак арифметической операции:";
Console.WriteLine(cal2);
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        Console.WriteLine(operand1 + operand2);
        break;
    case "-":
        Console.WriteLine(operand1 - operand2);
        break;
    case "*":
        Console.WriteLine(operand1 * operand2);
        break;
    case "/":
        if (operand2 == 0)
        {
            Console.WriteLine("Ошибка");
        }
        Console.WriteLine(operand1 / operand2);
        break;
    default:
        Console.WriteLine("Ошибка: Введен неиспользуемый арифметический знак");
        break;
}


//Задание 2

Console.WriteLine("Введите число от 0 до 100:");
int number = int.Parse(Console.ReadLine());
switch (number)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
    case 12:
    case 13:
    case 14:
        Console.WriteLine("Ваше число попадает в промежуток 0-14");
        break;
    case int i when i >= 15 && i <= 35:
        Console.WriteLine("Ваше число попадает в промежуток 15 - 35");
        break;
    case int i when i >= 36 && i < 50:
        Console.WriteLine("Ваше число попадает в промежуток 36 - 50");
        break;
    case int i when i > 50 && i <= 100:
        Console.WriteLine("Ваше число попадает в промежуток 50 - 100");
        break;
    case 50:
        Console.WriteLine("Ваше число попадает в промежуток 36 - 50 и 50 - 100");
        break;
    default:
        Console.WriteLine("Ошибка: указываемое число, не входит ни в один из имеющихся числовых промежутков");
        break;
}

//Задание 3

Console.WriteLine("Введите слово о погоде на русском языке:");
string word = Console.ReadLine();
switch (word)
{
    case "солнце":
        Console.WriteLine("sun");
        break;
    case "ветер":
        Console.WriteLine("wind");
        break;
    case "туча":
        Console.WriteLine("cloud");
        break;
    case "снег":
        Console.WriteLine("snow");
        break;
    case "закат":
        Console.WriteLine("sunset");
        break;
    case "восход":
        Console.WriteLine("sunrise");
        break;
    case "туман":
        Console.WriteLine("fog");
        break;
    case "холодно":
        Console.WriteLine("freez");
        break;
    case "тепло":
        Console.WriteLine("worm");
        break;
    case "погода":
        Console.WriteLine("weather");
        break;
    default:
        Console.WriteLine("Ошибка: указываемое слово не входит в словарь");
        break;
}

//Задание 4

Console.WriteLine("Введите любое целое число:");
int x = Convert.ToInt32(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
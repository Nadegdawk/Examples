Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task2": Task2(); break;
			case "Task4": Task4(); break;
			case "Task6": Task6(); break;
			case "Task8": Task8(); break;
			case "Task10": Task10(); break;
			case "Task19": Task19(); break;
			case "Task25": Task25(); break;
			case "Task29": Task29(); break;
            case "Seminar4": Seminar4(); break;
            case "Task26": Task26(); break;
            case "Task28": Task28(); break;
            case "Task30": Task30(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Seminar4()
{
    Console.WriteLine("Seminar4");

    int number = ReadInt("number");

    Console.WriteLine(GetSumUntil(number));
    
}

void Task26()
{
    // Console.WriteLine("Seminar41");

    // int number = ReadInt("number");

    // Console.WriteLine(GetDigitNumber(number));

    int number = ReadInt("number");
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count ++;
    }
    System.Console.WriteLine(count);
    
}

void Task28()
{
    Console.WriteLine("Task28");
    int number = ReadInt("number");
    System.Console.WriteLine(GetPowUntil(number));
}

void Task30()
{
    Console.WriteLine("Task30");
    int number = ReadInt("number");
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
	{
		array[i] = new Random().Next(0, 2);
	}
    Console.WriteLine(ArrayToString(array));
}

void Task2()
{
	Console.WriteLine("Task2");

	int firstNumber = ReadInt("First number");
	int secondNumber = ReadInt("Second number");

	if (IsLargeThen(firstNumber, secondNumber))
	{
		Console.WriteLine("First number > Second number");
	}
	else
	{
		Console.WriteLine("Second number > First number");
	}
}

void Task4()
{
	Console.WriteLine("Task4:");

	int firstNumber = ReadInt("First number");
	int secondNumber = ReadInt("Second number");
	int thirdNumber = ReadInt("Third number");

	Console.WriteLine($"The largest value is {FindMax(firstNumber, secondNumber, thirdNumber)}");
}

void Task6()
{
	Console.WriteLine("Task 6:");

	int number = ReadInt("Number");
	string evenSuffix = string.Empty; // string.Empty = "";

	if (!IsEven(number)) // ! - слово "Не"
	{
		evenSuffix = "not";
	}

	Console.WriteLine($"Input number is {evenSuffix} even");
}

void Task8()
{
	Console.WriteLine("Task8");
	int n = ReadInt("N");

	Console.WriteLine(GetNumbersAsLineUntil(n));
}

void Task10()
{
	Console.WriteLine("Task10");
	int number = ReadInt("number");

	Console.WriteLine($"The second digit is {GetDigitFromNumber(number, 2)}");
}

void Task19()
{
	Console.WriteLine("Task19");

	string number = ReadInt("number").ToString();

	if (number[0] == number[4] && number[1] == number[3])
	{
		Console.WriteLine("It's a palindrom");
	}
	else
	{
		Console.WriteLine("It's not a palindrom");
	}
}

void Task25()
{
	Console.WriteLine("Task25");

	int numberA = ReadInt("first number (A)");
	int numberB = ReadInt("second number (B)");

	Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
}

void Task29()
{
	Console.WriteLine("Task29");

	int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));
}

int FindMax(int firstNumber, int secondNumber, int thirdNumber)
{
	int max = firstNumber;

	if (!IsLargeThen(firstNumber, secondNumber))
	{
		max = secondNumber;
	}

	if (IsLargeThen(thirdNumber, max))
	{
		max = thirdNumber;
	}

	return max;
}

int ReadInt(string argumentName)            //ввод данных пользователем
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

bool IsLargeThen(int firstNumber, int secondNumber)         //сравнение чисел
{
	return firstNumber > secondNumber;
}

bool IsEven(int number)         //четность числа
{
	return number % 2 == 0; // == - сравнение (результаты сравнения: true, false)
}

string GetNumbersAsLineUntil(int n)         //вывод четных чисел
{
	string result = string.Empty;

	for (int i = 1; i < n; i++)
	{
		if (IsEven(i))
		{
			result += $"{i} , ";
		}
	}

	return result;
}

int GetDigitFromNumber(int number, int digitPosition)           //порядковый номер цифры в числе
{
	string numberString = number.ToString();
	int move = numberString.Length - digitPosition;

	return int.Parse(numberString[numberString.Length - digitPosition].ToString());
}

int Pow(int firstNumber, int secondNumber)          //возведение числа в любую степень
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}

int[] GetArray(int length)          //создание массива определенной длины
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}

string ArrayToString(int[] array)           //преобразование массива в строку
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}

int GetSumUntil(int n)          //суммирование чисел по порядку
{
    int result = 0;

    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;
}

int GetDigitNumber(int number)           //количество цифр в числе
{
	string numberString = number.ToString();
	int result = numberString.Length;
	return result;
}

int GetPowUntil(int n)          //умножение чисел по порядку (факториал)
{
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int[] GetArray01(int length)          //создание массива 0 1
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(0, 2);
	}
    return array;
}  
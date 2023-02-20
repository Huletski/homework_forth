//task1 Найти сумму чисел одномерного массива стоящих на нечетной позиции
/*

int ReadingInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArray(int length, int lowest, int hightest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest,hightest+1);
    return array;
}

void OutputArray(int[] array){
    foreach (int element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

int Sum(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i%2!=0) sum += array[i];
    return sum;
}

int length = ReadingInt("Введите длину массива: ");
int lowest = 0;
int hightest = 10;
int[] array = NewArray(length, lowest, hightest);
OutputArray(array);
Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечетных позициях: {Sum(array)}");

*/

//task2 Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

/*

int[] CreateArray(int length, int lowest, int hightest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest,hightest+1);
    return array;
}

void PrintArray(int[] array){
    foreach (int element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int FindAnEvenNumber(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0) count++;
    return count;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 100;
int hightest = 999;
int[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {FindAnEvenNumber(array)}");
Console.WriteLine($"Количество нечетных чисел в массиве: {array.Length-FindAnEvenNumber(array)}");

*/



//task3 В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] ???

/*
int lowest1 = 10;
int hightest1 = 99;
Console.WriteLine($"Количество элементов из отрезка [10,99]: {hightest1-lowest1+1}");
Console.WriteLine();


// Из одномерного массива из 123 чисел ВЫВЕСТИ ЭЛЕМЕНТЫ из отрезка [10,99]

int[] CreateArray(int length, int lowest, int hightest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest,hightest+1);
    return array;
}

void PrintArray(int[] array){
    foreach (int element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
    Console.WriteLine();
}

int[] CreateNewArray(int[] array, int newLowest, int newHightest){
    int length = newHightest-newLowest+1;
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = array[newLowest-1];
        newLowest++;
    }
    return newArray;
}

int length = 123;
int lowest = 0;
int hightest = 999;
int newLowest = 10;
int newHightest = 99;

int[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
PrintArray(CreateNewArray(array, newLowest, newHightest));

*/



//task4 Найти сумму чисел одномерного массива стоящих на нечетной позиции

/*
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int length, int lowest, int hightest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest,hightest+1);
    return array;
}

void PrintArray(int[] array){
    foreach (int element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

int Sum(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i%2!=0) sum += array[i];
    return sum;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 0;
int hightest = 10;
int[] array = CreateArray(length, lowest, hightest);
PrintArray(array);
Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечетных позициях: {Sum(array)}");

*/



//task5 Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


/*
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int length, int lowest, int hightest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest,hightest+1);
    return array;
}

void PrintArray(int[] array){
    foreach (int element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

int[] MultiplicationPairs(int[] array){
    int length = array.Length/2;
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
        newArray[i] = array[i]*array[array.Length-i-1];
    return newArray;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 0;
int hightest = 10;
int[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine("Произведение пар в одномерном массиве:");
PrintArray(MultiplicationPairs(array));

*/

// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int length, int lowest, int hightest){
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(random.NextDouble()*(hightest-lowest), 2);
    return array;
}

void PrintArray(double[] array){
    foreach (double element in array)
        Console.Write($"| {element} ");
    Console.WriteLine();
}

double DifferenceMaxMin(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }
    return max-min;
}

int length = ReadInt("Введите длину массива: ");
int lowest = 0;
int hightest = 20;
double[] array = CreateArray(length, lowest, hightest);

PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве: {DifferenceMaxMin(array)}");
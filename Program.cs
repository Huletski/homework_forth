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





//task3 В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] ???

/*

int minimum = 10;
int maximum = 99;

Console.WriteLine($"ellements in piece: [10,99]: {maximum-minimum+1}");
Console.WriteLine();


int[] NewArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(min,max +1);
    return array;
}

void OutputArray(int[] array)
{
    foreach (int element in array)

    Console.Write($"| {element} ");
    Console.WriteLine();
    Console.WriteLine();
}

int[] CreateArrayNew(int[] array, int lowest, int hightest)
{
    int length = hightest-lowest+1;
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
    {
      newArray[i] = array[lowest-1];
      lowest++;
    }
    return newArray;
}

int length = 123;
int lowest = 0;
int hightest = 999;
int newLowest = 10;
int newHightest = 99;

int[] array = NewArray(length, lowest, hightest);

OutputArray(array);
OutputArray(CreateArrayNew(array, newLowest, newHightest));


*/


//task4 Найти сумму чисел одномерного массива стоящих на нечетной позиции
/*

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] NewArray(int length, int minimum, int maximum)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(minimum,maximum +1);
    return array;
}

void ArrayOutput(int[] array)
{
    foreach (int element in array)

    Console.Write($"| {element} ");
    Console.WriteLine();
}

int Sum(int[] array){
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    
     if (i%2!=0) 
     {
     sum += array[i];
     }
    return sum;
}

int length = InputNum("Please enter length of array: ");
int minimum = 0;
int maximun = 10;
int[] result = NewArray(length, minimum, maximun);

ArrayOutput(result);
Console.WriteLine($"Product of numbers in one-dimensional array, those in odd positions: {Sum(result)}");

*/



//task5 Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

/*

int Input(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] NewArray(int length, int minimal, int maximum)
{
    int[] array = new int[length];
    Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(minimal, maximum +1);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int element in array)
    Console.Write($"| {element} ");
    Console.WriteLine();
}

int[] ArrayPairs(int[] array)
{
    int length = array.Length/2;
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
    newArray[i] = array[i]*array[array.Length-i-1];
    return newArray;
}

int length = Input("Please enter length of array: ");
int minimal = 0;
int maximum = 10;
int[] array = NewArray(length, minimal, maximum);

PrintArray(array);
Console.WriteLine("Product of pairs in one-dimensional array :");
PrintArray(ArrayPairs(array));
*/
/*

//task6 В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int length, int minimum, int maximum){
    double[] array = new double[length];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(random.NextDouble()*(maximum-minimum), 2);
    return array;
}

void OutputResult(double[] array){
    foreach (double element in array)

        Console.Write($"| {element} ");
        Console.WriteLine();
}

double ResultDifference(double[] array){
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }
    return max-min;
}

int length = InputNum("Plese, enter length of array: ");
int minimum = 0;
int maximum = 20;

double[] array = CreateArray(length, minimum, maximum);

OutputResult(array);
Console.WriteLine($"diference between maximum and minimun element in array: {ResultDifference(array)}");

*/
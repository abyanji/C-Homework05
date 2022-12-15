// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int SIZE = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 100;

double[] array = new double[SIZE];

double[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for(int i = 0 ; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

double MinNumber(double[] arr)
{
    double min = arr[0];
    for(int i = 1 ; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double MaxNumber(double[] arr)
{
    double max = arr[0];
    for(int i = 1 ; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
double minimum = MinNumber(array);
double maximum = MaxNumber(array);
double difference = maximum - minimum;
Console.WriteLine($"[{string.Join(", ", array)}] -> {difference}");
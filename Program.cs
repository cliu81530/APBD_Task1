// Console.WriteLine("Hello, World!");
int[] numbers = { 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10 };
int max = getMax(numbers);
double average = CalculateAverage(numbers);
Console.WriteLine("Max: " + max);
Console.WriteLine("Average: " + average);

static double CalculateAverage(int[] array)
{
    if(array.Length == 0 || array == null)
    {
        throw new ArgumentException("Array cannot be null or empty.");
    }
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    double average = (double)sum / array.Length;
    return average;
}

static int getMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

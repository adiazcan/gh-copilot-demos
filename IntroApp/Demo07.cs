namespace IntroApp;

internal class Demo07
{
    void FillArray()
    {
        int[] numbers = new int[10];
        var random = new Random();
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = random.Next(1, 100);
    }
}


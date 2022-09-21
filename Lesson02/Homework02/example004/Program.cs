int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };

int n = numbers.Length;
int i = 0;
int sum = 0;
int SA = 0;

while( i < n)
{
    sum = sum + numbers[i];
    i++;
}

SA = sum / n;
Console.WriteLine (SA);

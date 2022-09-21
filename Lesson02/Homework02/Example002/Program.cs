int N = 3246791;

if(N >=100)
{
    while( N > 999 )
    {
        N = N / 10;
    }
 
    int Rem = N % 10;
    Console.WriteLine(Rem);
}

else
{
   Console.WriteLine("Третьей цифры нет");
}
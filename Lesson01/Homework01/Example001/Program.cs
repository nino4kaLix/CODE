int numberA = -9;
int numberB = -3;
int max, min;

if (numberA > numberB)
{
   max = numberA;
   min = numberB;
}
else 
{
    max = numberB;
    min = numberA;
}
 Console.WriteLine("min = " + min);
 Console.WriteLine("max = " + max);
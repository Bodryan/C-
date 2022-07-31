Console.WriteLine("Введите число для возведения во вторую стпень");

int num = Convert.ToInt32(Console.ReadLine());
int rezult = power(num);
Console.WriteLine(rezult);

int power(int currentNumber)
{
    return currentNumber * currentNumber;
}
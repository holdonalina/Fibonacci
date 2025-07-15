Console.Write("Enter the position of Fibonacci number: ");
int position = int.Parse(Console.ReadLine());

int result = MathHelpers.GetFibonacci(position - 1);

Console.WriteLine($"Fibonacci number at position {position} is {result}"); 

public static class MathHelpers
{
  public static int GetFibonacci(int n)
  {
    if (n == 0)
      return 0;
    else if (n == 1)
      return 1;
    else
      return GetFibonacci(n - 1) + GetFibonacci(n - 2);
  }
}
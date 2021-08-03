using System;
using System.Collections.Generic;

namespace FibonacciNumbers
{
class FibonacciNumbers
{
static void Main( string [] args )
{
var fibonacciNumbers = new List<int> {1, 1};
while (fibonacciNumbers.Count < 20)
{
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous1);
}
foreach (var item in fibonacciNumbers)
Console.WriteLine(item);
}
}
}


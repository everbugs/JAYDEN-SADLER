
## Input And Output:
<pre><code>
using System;
namespace MyProject.Examples
{
    class ExampleOne
    {
        static void Main()
        {
            Console.Write("Enter 1st food name: ");
            string name1 = Console.ReadLine();
            int price1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd food name: ");
            string name2 = Console.ReadLine();
            int price2 = int.Parse(Console.ReadLine());
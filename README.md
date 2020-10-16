
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
            int total = price1 + price2;
            Console.WriteLine("Total price of {0} and {1} is {2}",name1,name2,total);
            Console.Write("Total price of "+ name1 + " and "+name2+ " is "+total);
            Console.ReadKey();
        }
    }
}
</code></pre>
Output:<br/>
Enter 1st food name: Rice<br/>
20<br/>
Enter 2nd food name: Dal<br/>
30<br/>
Total price of Rice and Dal is 50<br/>
using static System.Console;

namespace Lesson11_3_ExtensionMethod;



public static class ExtensionMethod
{
    public static void AllWant(this IEnumerable<int> collection, bool isEven = true)
    {
        collection
            .Where(x => (x % 2).ToBoolean() != isEven)
            .ToList()
            .ForEach(x => WriteLine(x));
    }


    public static bool ToBoolean(this int x) => Convert.ToBoolean(x);


    public static bool HasSymbol(this string str, string symbol)
        => str.ToUpper().Contains(symbol.ToUpper());
}


class Program
{
    static void Main()
    {
        IEnumerable<int> numbers = Enumerable.Range(10, 20);

        // numbers
        //     .Where(x => x % 2 == 0)
        //     .ToList()
        //     .ForEach(x => WriteLine(x));

        // numbers.AllWant(false);
        // 
        // 
        // int n = 0;
        // WriteLine(n.ToBoolean());



        // string str = "AlmA";
        // WriteLine(str.HasSymbol("A"));





    }
}
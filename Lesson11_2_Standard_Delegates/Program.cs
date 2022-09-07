using static System.Console;

namespace Lesson11_2_Standard_Delegates;

// Anonymous function
// Lambda expression

class Program
{
    static void Main()
    {
        // Action    (0-16)  parameter | return type (void)
        // Predicate (1)     parameter | return type (bool)
        // Func      (0-16)  parameter | return type (void-, qalan hamsi)


        Action a1 = null!;
        a1 += CustomMethod;
        a1 += delegate () { WriteLine("Anonymous function"); };
        a1 += () => WriteLine("Lambda expression");

        // a1.Invoke();


        //////////////////////////

        Action<int, string> a2 = null!;

        a2 += CustomMethodWithParam;

        a2 += delegate (int i, string s)
        {
            WriteLine($"Anonymous function {i} - {s}");
        };

        a2 += (i, s) => WriteLine($"Lambda expression {i} - {s}");
        // a2 += (int i, string s) => WriteLine($"Lambda expression {i} - {s}");




        // a2.Invoke(5, "Hello");




        //////////////////////////




        // TASK
        //// Predicate
        // (int) -> isEven

        Predicate<int> p1 = null!;

        p1 += delegate (int i) { return i % 2 == 0; };
        p1 += i => i % 2 == 0;

        // WriteLine(p1.Invoke(5));








        //// Func
        // string - string.Upper

        Func<string, string> f1 = null!;

        f1 += delegate (string s) { return s.ToUpper(); };
        f1 += s => s.ToUpper();

        // WriteLine(f1.Invoke("Salam"));


        ///////////////

        Func<string, int, int> f2 = null!;
        f2 += delegate (string s, int i) { return s.Length * i; };
        f2 += (s,  i) => s.Length * i;

        // WriteLine(f2("Hello", 10));


        foreach (var del in f2.GetInvocationList())
            WriteLine(del.DynamicInvoke("Hello", 10));
    }





    static void CustomMethod()
        => WriteLine("CustomMethod");

    static void CustomMethodWithParam(int i, string s)
        => WriteLine($"CustomMethodWithParam {i} - {s}");
}



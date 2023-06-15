using System;

namespace Module1_Class1_ConsoleApp;

internal sealed class Program
{
    internal static void Main(string[] args)
    {
        int x = 0;


        Console.WriteLine(++x);
        Console.WriteLine(x);

        Example6();
    }

    public static void SimpleFunction()
    {
        // Comments.
        // Console.WriteLine("SimpleFunction");
        // No Code.

        /*
          Block of comments
        */
    }

    public static void Example1()
    {
        Console.WriteLine("Example 1:");

        int age = 25;
        string name = "Vlad";

        Console.WriteLine(name);
        Console.WriteLine(age);

        Console.WriteLine("Change Variable name");

        name = "Pokemon";

        Console.WriteLine(name);
        Console.WriteLine(age);

        string nickName = name;

        Console.WriteLine("Nick Name");

        Console.WriteLine(nickName);
        Console.WriteLine(age);

        string newName = "Jon";
        name = newName + " ----- " + name;

        Console.WriteLine(name);
        Console.WriteLine(age);
    }

    public static void Example2()
    {
        Console.WriteLine("Example2");

        bool trueOrFalse = true; // true of false | Struct
        byte @byte = 255;  // 0 - 255 | Struct
        int @int = 1000245000; // | Struct
        uint @uint = 998812321; // not possible to save -1 -2 -3 .... because of unsigned int.
        double @double = 2.52; // | Struct
        char charA = 'A'; // ASCII Table 65 | Struct | 2 byte

        string @string = "Long $ Long  @ Text"; // | Class
        object o1 = @string; // | Class
        object o2 = new object(); // | Class
    }

    public static void Example3()
    {
        Console.WriteLine("Example3");

        // The same like Example2, var is alias.

        var trueOrFalse = true; // true of false | Struct
        byte @byte = 250;  // 0 - 255 | Struct
        var @int = 1000245000; // | Struct
        var @uint = 99881232132892; // not possible to save -1 -2 -3 .... because of unsigned int.
        var @double = 2.52; // | Struct
        var charA = 'A'; // ASCII Table -> A == 65 | Struct

        var @string = "Long Long Long Long Text"; // | Class
        var o1 = charA; // | Class
        var o2 = new object(); // | Class
    }

    public static void ExampleReadFromConsole()
    {
        Console.WriteLine("ExampleReadFromConsole");

        string textFromConsole = Console.ReadLine();

        Console.WriteLine(textFromConsole);
    }

    public static void Example4()
    {
        Console.WriteLine("Example4");

        int a = 2;

        // The same
        a = a + 10; //  == a += 10;
        a += 10;
        Console.WriteLine(a); // 22

        // The same
        a = a - 5;
        a -= 5;
        Console.WriteLine(a); // 12
    }

    public static void Example5()
    {
        Console.WriteLine("Example5");

        int x = 0;
        x--; // x = x + 1; x += 1
        Console.WriteLine(x);

        --x; //x = x + 1;
        Console.WriteLine(x);

        Console.WriteLine("==============");

        int x1 = 5;
        int z1 = ++x1; // x1 = x1 + 1; z2 = x1;

        Console.WriteLine(x1); // 6
        Console.WriteLine(z1); // 6

        int x2 = 5;
        int z2 = x2++; // z2 = x1; x1 = x1 + 1

        Console.WriteLine(x2); // 6
        Console.WriteLine(z2); // 5
    }

    public static void Example6()
    {
        Console.WriteLine("Example6");

        int a0 = 2;
        int b0 = 2;
        bool c0 = a0 == b0;

        Console.WriteLine(c0); // True

        Console.WriteLine("===============");

        int a1 = 2;
        int b1 = 4;
        bool c1 = a1 == b1;

        Console.WriteLine(c1); // False

        Console.WriteLine("===============");

        int a2 = 2;
        int b2 = 2;
        bool c2 = a2 != b2;

        Console.WriteLine(c2); // False

        Console.WriteLine("===============");

        int a3 = 2;
        int b3 = 4;
        bool c3 = a3 != b3;

        Console.WriteLine(c3); // True
    }
}

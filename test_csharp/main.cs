// main.cs : File is test of Fibonacci DLL written on C/C++ 
using System; // the using System line means that you are using the System library in file.
              // Which gives you some useful classes like Console or functions/methods like WriteLine. 
using System.Runtime.InteropServices;



// FibonacciTestCSharp is something that identifies and encapsulates code within that namespace. 
// It's like package in Java. This is handy for oranizing codes.
namespace FibonacciTestCSharp
{
    //  class test - is the name of your entry-point class
    // Unlike Java, which requires you to name it Main, you can name it whatever in C#.
    class test
    {
        [DllImport(@"D:\\Alex Povod\\projects\\fibonacci\\x64\\Release\\fibonacci.dll")]
        private static extern void fibonacci_init(ulong a, ulong b);
        
        [DllImport(@"D:\\Alex Povod\\projects\\fibonacci\\x64\\Release\\fibonacci.dll")]
        private static extern short fibonacci_index();
        
        [DllImport(@"D:\\Alex Povod\\projects\\fibonacci\\x64\\Release\\fibonacci.dll")]
        private static extern ulong fibonacci_current();

        [DllImport(@"D:\\Alex Povod\\projects\\fibonacci\\x64\\Release\\fibonacci.dll")]
        private static extern bool fibonacci_next();

        public static void Main() //  is the entry-point method of your program.
        {
            fibonacci_init(1, 1);

            do{ Console.WriteLine($"{fibonacci_index()} : {fibonacci_current()}"); }  while (fibonacci_next());

            // Report count of values written before overflow.
            Console.WriteLine($"{fibonacci_index() + 1} Fibonacci sequence values fit in an unsigned 64-bit integer.");
             
            Console.ReadKey();
        }
    }
}

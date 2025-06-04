using System.Runtime.Intrinsics.X86;

namespace LogicGates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a=false;
            bool b=false;
            bool c=false;
            Console.Write("Enter in you input for A write true for on or false for off:");
            a=Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter in you input for B write true for on or false for off:");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter in you input for C write true for on or false for off:");
            c = Convert.ToBoolean(Console.ReadLine());
            Console.Write($"{a}{b}{c}");
            bool andOutput = AndGate(a, b, c);
            bool NotOutput=NotGate(a);
            bool OrOutput = OrGate(a, b, c);
            bool NorOutput=NorGate(a,b,c);
            bool NandOutput=NandGate(a,b,c);
            bool XorOutput=XorGate(a,b,c);
            bool XnorOutput=XnorGate(a,b,c);
            Console.WriteLine(XorOutput);
            Console.ReadLine();
        }
        static bool NotGate(bool a)
        {
            Console.WriteLine("Not Gate Truth Table");
            Console.WriteLine("A\tOutput");
            Console.WriteLine(new string('-',25));
            Console.WriteLine("0\t1\n1\t0");
            bool output = !a;
            return output;
        }
        static bool AndGate(bool a, bool b, bool c)
        {
            Console.WriteLine("And Gate Truth Table");
            Console.WriteLine("A\tB\tOutput");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("0\t0\t0\n0\t1\t0\n1\t0\t0\n1\t1\t1");
            return (a == true && b == true && c == true);
        }
        static bool OrGate(bool a, bool b, bool c)
        {
            Console.WriteLine("Or Gate Truth Table");
            Console.WriteLine("A\tB\tOutput");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("0\t0\t0\n0\t1\t1\n1\t0\t1\n1\t1\t1");
            return (a!=false || b!=false || c!=false);
        }
        static bool NorGate(bool a, bool b,bool c)
        {
            Console.WriteLine("Nor Gate Truth Table");
            Console.WriteLine("A\tB\tOutput");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("0\t0\t1\n0\t1\t0\n1\t0\t0\n1\t1\t0");
            return(NotGate(OrGate(a,b,c)));
        }
        static bool NandGate(bool a, bool b, bool c)
        {
            Console.WriteLine("Nand Gate Truth Table");
            Console.WriteLine("A\tB\tOutput");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("0\t0\t1\n0\t1\t1\n1\t0\t1\n1\t1\t0");
            return (NotGate(AndGate(a,b,c)));
        }
        static bool XorGate(bool a,bool b,bool c)
        {
            Console.WriteLine("Xor Gate Truth Table");
            Console.WriteLine("A\tB\tOutput");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("0\t0\t0\n0\t1\t1\n1\t0\t1\n1\t1\t0");
            return((a && (!b||!c))|| (b && (!a||!c))|| (c&& (!a||!b)));

        }
        static bool XnorGate(bool a,bool b,bool c)
        {
            Console.WriteLine("Xnor Gate Truth Table");
            Console.WriteLine("A\tB\tOutput");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("0\t0\t1\n0\t1\t0\n1\t0\t0\n1\t1\t1");
            return(NotGate(XorGate(a,b,c)));
        }
    }
}

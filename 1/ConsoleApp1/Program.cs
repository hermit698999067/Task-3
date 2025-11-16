using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"sbyte   | {sizeof(sbyte)} bytes | {sbyte.MinValue} .. {sbyte.MaxValue}");
        Console.WriteLine($"byte    | {sizeof(byte)}  bytes | {byte.MinValue} .. {byte.MaxValue}");
        Console.WriteLine($"short   | {sizeof(short)} bytes | {short.MinValue} .. {short.MaxValue}");
        Console.WriteLine($"ushort  | {sizeof(ushort)} bytes | {ushort.MinValue} .. {ushort.MaxValue}");
        Console.WriteLine($"int     | {sizeof(int)} bytes | {int.MinValue} .. {int.MaxValue}");
        Console.WriteLine($"uint    | {sizeof(uint)} bytes | {uint.MinValue} .. {uint.MaxValue}");
        Console.WriteLine($"long    | {sizeof(long)} bytes | {long.MinValue} .. {long.MaxValue}");
        Console.WriteLine($"ulong   | {sizeof(ulong)} bytes | {ulong.MinValue} .. {ulong.MaxValue}");
        Console.WriteLine($"float   | {sizeof(float)} bytes | {float.MinValue} .. {float.MaxValue}");
        Console.WriteLine($"double  | {sizeof(double)} bytes | {double.MinValue} .. {double.MaxValue}");
        Console.WriteLine($"decimal | {sizeof(decimal)} bytes | {decimal.MinValue} .. {decimal.MaxValue}");
    }
}

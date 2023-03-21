// See https://aka.ms/new-console-template for more information
public class Penjumlahan
{
    public static T jumlahTigaAngka<T>(T One, T Two, T Three) {
        return ((dynamic)One + (dynamic)Two + (dynamic)Three);
    }
}

public class Program { 
    public static void Main(string[] args)
    {
        Console.WriteLine(Penjumlahan.jumlahTigaAngka<int>(13, 2, 21));

    }
}
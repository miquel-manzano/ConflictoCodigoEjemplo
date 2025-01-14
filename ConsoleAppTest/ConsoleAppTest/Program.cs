internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escribe un numero:");
        int userNum = UserIntImput();
        Console.WriteLine($"Tu numero es: {userNum}");
    }

    public static int UserIntImput()
    {
        return int.Parse(Console.ReadLine());
    }
}
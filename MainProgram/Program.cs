using MyLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GetSecondsPrintTime();
    }

    private static void GetSecondsPrintTime()
    {
        const string Msg = "Insereix número de segons";
        int totalSeconds =0;

        Console.WriteLine(Msg);
        try
        {
            totalSeconds = int.Parse(Console.ReadLine());
            Console.WriteLine(MyLibrary.Math.Seconds2HoursTime(totalSeconds));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
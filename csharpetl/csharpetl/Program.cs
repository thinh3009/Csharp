internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        const float pi = 3.14f;
        float r;
        Console.WriteLine("nhap r: ");
        r=float.Parse(Console.ReadLine());

        float chuvi = 2 * r * pi;
        float dientich = pi * (r * r);
        Console.WriteLine("chuvi" + chuvi);
        Console.WriteLine("dientich" + dientich);
        Console.ReadLine();
    }
}
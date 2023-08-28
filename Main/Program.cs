using System.Security.Cryptography;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa 1 \n");
        Ejercicio1();
        Console.WriteLine("Programa 2 \n");
        Ejercicio2();
    }
    public static void Ejercicio1() {
        Random random = new Random();
        int n= random.Next(0,1000000);
        Console.WriteLine("El número aleatorio es:" + n + "\n" + "Y el 30% de ese número es: " + n*.30);
        }

    public static void Ejercicio2() {
        int n1, n2, n3,n4;
        Console.WriteLine("Ingrese tres números enteros: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = (n1 + n2 + n3) / 3;
        Console.WriteLine("El promedio de los números es " +n1+", " + n2 + ", " + n3 + " es: " + n4);

    }

    public static void Ejercicio3()
    {



    }

}
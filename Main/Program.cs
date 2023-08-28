using System.Security.Cryptography;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa 1 \n");
        Ejercicio1();
        Console.WriteLine("\nPrograma 2 \n");
        Ejercicio2();
        Console.WriteLine("\nPrograma 3 \n");
        Ejercicio3();
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
        int h, m; 
        double total; 
        Console.WriteLine("Ingrese la cantidad de mujeres, luego la cantidad de hombres");
        m = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());
        total = h + m;
        Console.WriteLine("El porcentaje de mujeres es: " + (m*100/total) + "%, y el porcentaje de hombres es: " + (h*100 / total)+"%");



    }

}
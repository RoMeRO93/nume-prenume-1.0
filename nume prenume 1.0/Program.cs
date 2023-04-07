using System;

class Program
{
    static void Main(string[] args)
    {
        string nume;
        string prenume;

        Console.WriteLine("Introduceti numele:");
        nume = Console.ReadLine();

        Console.WriteLine("Introduceti prenumele:");
        prenume = Console.ReadLine();

        string numeIntreg = prenume + " " + nume;

        
        Console.WriteLine("Salut, " + prenume + "!");
        Console.WriteLine("Numele complet este: " + numeIntreg);
        Console.Read();
    }
}
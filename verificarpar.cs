using System;

class Program {
    static void Main() {
        Console.Write("digita numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0) {
            Console.WriteLine("numero eh par");
        } else {
            Console.WriteLine("numero eh impar");
        }
    }
}
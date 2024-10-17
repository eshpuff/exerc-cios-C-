using System;

class Program {
    static void Main() {
        Console.Write("digite um numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("digite um numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;
        Console.WriteLine("soma: " + soma);
    }
}

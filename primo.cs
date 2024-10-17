using System;

class Program {
    static void Main() {
        Console.Write("digite um nuemro: ");
        int numero = int.Parse(Console.ReadLine());
        bool ehPrimo = true;

        if (numero <= 1) {
            ehPrimo = false;
        } else {
            for (int i = 2; i <= Math.Sqrt(numero); i++) {
                if (numero % i == 0) {
                    ehPrimo = false;
                    break;
                }
            }
        }

        if (ehPrimo) {
            Console.WriteLine("eh primo");
        } else {
            Console.WriteLine("nao eh primo");
        }
    }
}

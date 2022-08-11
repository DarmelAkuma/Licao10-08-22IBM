using System;

namespace Licao10_08_22 {
    class Program {
        static void Main(string[] args) {
            Tabuada();
        }
        static void Tabuada() {
            int numero, resultado;
            Console.WriteLine("Digite o número: ");
            numero = int.Parse(Console.ReadLine());
            for (int x = 0; x <= 10; x++) {
                resultado = numero * x;
                Console.WriteLine(x + " X " + numero + " = " + resultado);
            }
        }
    }
}

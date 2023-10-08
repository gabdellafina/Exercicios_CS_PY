///Crie um programa que permita ao usuário entrar com dois números. Executar as quatro operações com esses dois números (Soma, Subtração, multiplicação, divisão). 

using System;

class Ex02 {
    static void Main (string[] args) {
        double n1, n2, r;

        Console.WriteLine("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        
        r = n1 + n2;
        Console.WriteLine("A soma é: "+r);

        r = n1 - n2;
        Console.WriteLine("A subtração é: "+r);

        r = n1 * n2;
        Console.WriteLine("A multiplicação é: "+r);

        r = n1 / n2;
        Console.WriteLine("A divisão é: "+r);
    }
}
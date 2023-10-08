///Elaborar um programa para calcular a média aritmética de três números digitados pelo usuário.
///

using System;

class Ex04 {
    static void Main (string[] args) {
        double n1, n2, n3, media;

        Console.WriteLine("Digite o primeiro número: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número: ");
        n3 = Convert.ToDouble(Console.ReadLine());
        
        media = (n1 + n2 + n3) / 3;
        Console.WriteLine("A média é: "+media);
    }
}
///Escreva um programa para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo.
///

using System;

class Ex06 {

public static void Main (string[] args) {

double l1, l2, r;

Console.WriteLine ("Tamanho de um dos lados do retângulo em cm: ");

l1 = double.Parse(Console.ReadLine());

Console.WriteLine ("Tamanho do outro lado do retângulo em cm: ");

l2 = double.Parse(Console.ReadLine());

r = l1 * l2;

Console.WriteLine ("A área do retângulo é: "+r+"m²");

}

}
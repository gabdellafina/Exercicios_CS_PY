///Escreva um código em que o usuário entre com 3 valores e faça o calculo do delta da formula de Bhaskara. Delta = (b*b)-4*a*c;
///

using System;

class Ex08 {

public static void Main (string[] args) {

double n1, n2, n3, D;

Console.WriteLine ("Informe o primeiro número: ");

n1 = double.Parse(Console.ReadLine());

Console.WriteLine ("Informe o segundo número: ");

n2 = double.Parse(Console.ReadLine());

Console.WriteLine ("Informe o terceiro número: ");

n3 = double.Parse(Console.ReadLine());

D = (n2*n2)-4*n1*n3;

Console.WriteLine ("O valor de delta é "+D);

}

}
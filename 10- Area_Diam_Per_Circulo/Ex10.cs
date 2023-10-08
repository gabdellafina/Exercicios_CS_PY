// Desenvolva um programa para calcular a área, diâmetro e perímetro do círculo.
// A = π . r²
// d=2 . r
// P = 2 . π . r


using System;

class Ex10 {

public static void Main (string[] args) {

double r, a, d, p;

Console.WriteLine ("Informe o raio do círculo: ");

r = double.Parse(Console.ReadLine());

a = Math.Round ((Math.PI * Math.Pow(r,2)),2);

d = 2 * r;

p = Math.Round ((2 * Math.PI * r),2);

Console.WriteLine ("O valor da área é "+a);

Console.WriteLine ("O valor do diâmetro é "+d);

Console.WriteLine ("O valor do perímetro é "+p);

}

}
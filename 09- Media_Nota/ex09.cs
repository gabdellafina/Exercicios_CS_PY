/// Faça um código em C# que leia três notas de um aluno, calcule e escreva a média final deste aluno. Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média final é:
/// 

using System;

class Ex09 {

public static void Main (string[] args) {

double n1, n2, n3, M;

Console.WriteLine ("Informe a primeiro nota: ");

n1 = double.Parse(Console.ReadLine());

Console.WriteLine ("Informe a segundo nota: ");

n2 = double.Parse(Console.ReadLine());

Console.WriteLine ("Informe a terceira nota: ");

n3 = double.Parse(Console.ReadLine());

M = ((n1 * 2) + (n2 * 3) + (n3 * 5))/10;

Console.WriteLine ("O valor da média é "+M);

}

}
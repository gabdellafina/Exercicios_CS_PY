/// Faça um código em que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
/// 

using System;

class Program {

public static void Main (string[] args) {

int a, m, d, A, M, D;

Console.WriteLine ("Informe a sua idade (anos): ");

a = int.Parse(Console.ReadLine());

Console.WriteLine ("Informe a sua idade (meses): ");

m = int.Parse(Console.ReadLine());

Console.WriteLine ("Informe a sua idade (dias): ");

d = int.Parse(Console.ReadLine());

A = 365 * a;

M = 30 * m;

D = A + M + d;

Console.WriteLine ("Você tem "+D+" dias");

}

}
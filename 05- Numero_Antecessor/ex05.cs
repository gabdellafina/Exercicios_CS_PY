///Escreva um código para ler um valor (do teclado) e escrever (na tela) o seu antecessor.
///

using System;

class Program {

public static void Main (string[] args) {

int n1, r;

Console.WriteLine ("Entre um número: ");

n1 = int.Parse(Console.ReadLine());

r = n1 - 1;

Console.WriteLine ("O antecessor desse número é: "+r);

}

}
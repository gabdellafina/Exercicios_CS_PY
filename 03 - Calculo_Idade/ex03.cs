///Desenvolva um programa e fluxograma para calcular a idade de uma pessoa, entrando com o ano de nascimento e ano atual.
///

using System;

class Ex03 {
    static void Main (string[] args) {
        int ano_nasc, ano_atual, idade;

        Console.WriteLine("Digite o ano de seu nascimento: ");
        ano_nasc = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano atual: ");
        ano_atual = int.Parse(Console.ReadLine());

        idade = ano_atual - ano_nasc;
        Console.WriteLine("Sua idade é: "+idade);
    }
}
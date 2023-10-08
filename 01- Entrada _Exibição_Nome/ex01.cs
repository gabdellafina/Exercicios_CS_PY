/// <summary>
/// Desenvolva um programa que permita a entrada do nome do usuário e exiba na tela.
/// </summary>

class Ex01 {
    static void Main (string[] args) {
        string nome;

        Console.WriteLine ("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine ("Seu nome é: "+nome);
    }
}
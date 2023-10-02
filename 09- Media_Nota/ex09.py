''' Faça um código que leia três notas de um aluno, calcule e escreva a média final deste aluno. Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5. Fórmula para o cálculo da média final é:'''

n1 = (float)(input("Informe a primeira nota: "))
n2 = (float)(input("Informe a segunda nota: "))
n3 = (float)(input("Informe a terceira nota: "))

M = ((n1 * 2) + (n2 * 3) + (n3 * 5))/10;

print("O valor da média é ",M);

''' Faça um código que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias.'''

a = (int)(input("Digite sua idade em anos: "))
m = (int)(input("Digite sua idade em meses: "))
d = (int)(input("Digite sua idade em dias: "))

anos = 365 * a
meses = 30 * m
dias = anos + meses + d

print("Sua idade em dias é: ",dias)

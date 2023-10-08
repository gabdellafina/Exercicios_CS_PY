'''
Desenvolva um programa para calcular a área, diâmetro e perímetro do círculo.
A = π . r²
d=2 . r
P = 2 . π . r
'''

import math

raio = float(input("Digite o raio do círculo: "))

area = round((math.pi * raio**2),2)
diam = 2 * raio
perim = round((2 * math.pi * raio),2)

print("O valor da área é ",area);

print("O valor do diâmetro é ",diam);

print("O valor do perímetro é ",perim);
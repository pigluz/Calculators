# -*- coding: utf-8 -*-

import time

print("Witaj w kalkulatorze!")
time.sleep(1)
print("Najpierwsz zacznijmy od pytan:")

print("Jak sie nazywasz\u003F")
imie = input()

print("Jakie masz nazwisko\u003F")
nazwisko = input()

print("Ile masz lat\u003F")
wiek = float(input())

print("Gdzie mieszkasz\u003F")
miasto = input()

print("Do jakiej szkoly chodzisz\u003F")
szkola = input()

print("Dobrze")
time.sleep(1)

print(
    "Imie: ",
    imie,
    "\n" "Nazwisko: ",
    nazwisko,
    "\n" "Wiek: ",
    wiek,
    "\n" "Miasto: ",
    miasto,
    "\n" "Szkola: ",
    szkola,
    "\n",
)

time.sleep(1)
print("Czy te dane sa poprawne\u003F")
wybor = input()

def is_data_correct():
    if wybor == "Tak":
        print("Dobrze! Przejdzmy dalej.")
    else:
        print("No to pa. lol...")

is_data_correct()


time.sleep(2)
print("Przejdzmy do kalkulatora!")
print("Podaj pierwsza liczbe ")
num1 = float(input())
print("Podaj druga liczbe ")
num2 = float(input())
print("Podaj operatora (+  -  /  *  )")
oper = input()

def calculator():
    if oper == "+":
        result = num1 + num2
        print("Twoj wynik to ", result)
    elif oper == "-":
        result = num1 - num2
        print("Twoj wynik to ", result)
    elif oper == "*":
        result = num1 * num2
        print("Twoj wynik to ", result)
    elif oper == "/":
        result = num1 / num2
        print("Twoj wynik to ", result)
    else:
        print("Zly operator...")

calculator()
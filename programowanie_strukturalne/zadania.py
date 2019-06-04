#oblicz wartosc (a2+b)/(a+b)2    (a+b)2 musi byc rozne od 0!!(try)

def wartosc(a, b):

    try:
        result (sqrt(a)+b)/sqrt(a+b)
        print(f'({a}2 + {b}) / ({a}+{b})2 = {result}')

    except:
        print('proba dzielenia przez 0')

wartosc(a = input("Podaj a: "), b = input("Podaj b: "))


#zadanie 2, wykorzystujac zmienne typu double oblicz wartisc wyrazenia
#a2+b dla c>0
#a-b2 dla c<0
#1/(a-b) dla c = 0

import math

a=input('Podaj liczbe a: ')
a=float(a)
b=input('Podaj liczbe b: ')
b=float(b)
c=input('Podaj liczbe c: ')
c=float(c)

if c>0:
    print('wartosc wyrazenia wynosi: ', (math.pow(a, 2))+b)

if c<0:
    print('wartosc wyrazenia wynosi: ', a-(math.pow(b, 2)))

if c==0 and a==b:
    print('proba dzielenia przez 0!')
elif c==0:
    print('wartosc wyrazenia wynosi: ', 1/(a-b))

#zadanie 3 najwiekszy wspolny dzielnik liczb dodatnik (nie uzywajac dzielenia), wykorzystujac alg. Euklidesa


a=input('Podaj liczbe >=0: ')
a=int(a)

b=input('Podaj liczbe >=0: ')
b=int(b)

def NWD(a,b):
    c=mod(a,b)
    a=b
    b=c

    if b==0:
        print('NWD wynosi: ', a)
    else:
        return NWD(a,b)

#oblicz wartosc (a2+b)/(a+b)2

def wartosc(a, b):

    try:
        result (sqrt(a)+b)/sqrt(a+b)
        print(f'({a}2 + {b}) / ({a}+{b})2 = {result}')

    except:
        print('proba dzielenia przez 0')

wartosc(a = input("Podaj a: "), b = input("Podaj b: "))

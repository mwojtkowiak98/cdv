def witaj():
    print('witaj!')

witaj()

def wyswietlWiek(wiek):
    print(f'twoj wiek: {wiek}')

wyswietlWiek(23)

def iloczyn(a, b):
    return a*b

print('Iloczyn wynosi: ',iloczyn(3,4))

def iloraz(a, b):
    return a/b

x=iloraz(4,5)

print(f'Iloraz wynosi: {x}')
print(type(x))

print(iloraz(b=10, a=3))

'''
uzytkownik podaje z klawaitury:
marka, model, pojemnosc, vmax
utworz funkcje ktora pobierze dane od uzytkownika i przypisze do slownika
utworz druga funkcje wyswietlajaca dane w formacie:
Marka:...
Model:...
'''

def wpisz():
    marka=input('Podaj marke:')
wpisz(marka)

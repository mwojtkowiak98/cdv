#zmienne globalne i lokalne

#precyzja
x="{0:.3f}".format(5)
print(x) #5.000

#napisz funkcje ktora jako argument przyjmuje wartosc zlotych i zamienia dane
#po kursie franka. Wyswietl ile uzytkownik kupi frnakow za podana kwote
print('\n\n')

def waluty():
    print('Ile zlotowek')
    y=input()
    print('kurs franka')
    chf=3.815
    print(chf)
    print('kupisz tyle funtow', y*chf)
waluty()




#zmienna globalna

zmiennaGlobal=10
print(f'Wartosc zmiennej globalnej: {zmiennaGlobal}')
print(f'Id zmiennej globlalnej: {id(zmiennaGlobal)}')

def spr():
global zmiennaGlobal
zmiennaGlobal=20
print(f'wartosc zmiennej globalnej wewnatrz fukncji: {zmiennaGlobal}')
print(f'Id zmiennej globlalnej wewnatrz funkcji: {id(zmiennaGlobal)}')

spr()

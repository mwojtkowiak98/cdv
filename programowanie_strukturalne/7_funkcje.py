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
wpisz()


#przekazywanie argumentow przez referencje
def show(name):
    print(f'Przed modyfikacja: {name}')
    name[0]='Beata'
    name[1]='Barbara'
    name[2]='Bogdan'
    name[3]='Janusz'
    name[4]='Karolina'
    print(f'Po modyfikacji: {name}')
    print(f'Id po modyfikacji: {id(name)}')

data=['Anna', 'Agnieszka', 'Andrzej']
print(f'Przed wywolaniem funkcji show: {data}')
print(f'Id obiektu przed funckja show: {id(data)}')
print()
show(data)
print(f'Po wywolaniu funkcji show: {data}')

###########slownik

data1={0: 'Artur', 1: 'Andrzej'}
print(f'id przed modyfikacja {id(data1)}')
show(data1)

#przekazywanie argumentu przez wartosc

print('\n\n')

def show1(city):
    print(f'Przed modyfikacja: {city}')
    city[0]='Berlin'
    city[1]='Londyn'
    print(f'Po modyfikacji: {city}')
    print(f'Id po modyfikacji: {id(city)}')

miasto=['Poznan', 'Torun']
print(f'Przed wywolaniem fukncji show1 {miasto}')
print(f'Id show1: {id(miasto)}')
show1(list(miasto))
print(f'Po wywolaniu show1 {miasto}')


######## slownik

miasto1={
0: 'Gniezno',
1: 'Poznan'
}

print(f'Przed wywolaniem show1 {miasto1}')
print(f'Id miasto show1 {id(miasto1)}')
show1(dict(miasto1))
print(f'Po wywolaniu show1 {miasto1}')


#############################################################

#try except

def dzielenie(Liczba1, Liczba2):
    try:
    result Liczba1 / Liczba2
    print(f'{x}/{y} = {result}')
except:
    print('Error, dzielisz przez 0!')

dzielenie(2, 0)

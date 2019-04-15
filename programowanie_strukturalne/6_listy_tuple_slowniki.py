#listy

programowanie=['Python', 'Php,', 'Java']
print(type(programowanie))
programowanie.append('C#')
programowanie.append('PHP')
print(programowanie)
ile=programowanie.count("php")
print(f'ile razy jest php: {ile}')

#tuple
imiona=('Julia', 'Anna', 'Tomek')
print(imiona)
print(type(imiona))
pierwszy=imiona[0]
print(pierwszy)

#słowniki
osoba={
'imie':'Julia',
'nazwisko':'Kowalski',
'wiek':23
}

print(osoba)
print(type(osoba))
print(osoba['imie'])
print(osoba.keys())
print(osoba.get('wzrost','brak danych'))

'''
utworz slownik i przypisz mu 3 imiona podane z klawiatury
wyswietl dane na ekranie w formacie:
imie1: ....
imie2: ....
'''
imie1=input('Podaj imie1:')

imie2=input('Podaj imie2:')

imie3=input('Podaj imie3:')


imiona={
print('imie1'),print(imie1),
'imie2':print(imie2),
'imie3':print(imie3),
}

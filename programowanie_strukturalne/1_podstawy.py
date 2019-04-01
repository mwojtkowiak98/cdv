print("CDV")
print(10)

#komentarz

'''
komentarz
w
wielu liniach
'''

#potegowanie 2 do potegi 10
potega = 2 ** 10
print (potega)

#pobieranie danych z klawiatury
imie = input("podaj imie: ")
#+ oznacza konkatenacje
print("Twoje imie podane z klawiatury: " + imie)

nazwisko = input("Podaj nazwisko: ")
print("twoje nazwisko podane z klawiatury: ", nazwisko)

#twoje imie: [zmienna imie], twoje nazwisko: [zmienna nazwisko]
print("Twoje imie: ", imie, ", Twoje nazwisko: ", nazwisko)

'''
uzytkownik podaje z klawiatury swoj wiek,
wyswietl dane w formacie: Twoj wiek: [wiek] lat
'''

#end= w tej samej linii, nie przechdozi do kolejnej
print("Podaj swoj wiek: ", end="")
wiek = input()
print(type(wiek)) #str, typ danych
print("Twój wiek:", wiek, "lat")
print("Twój wiek: " + wiek + " lat")

wiek1 = 20
print(type(wiek1))
print("Twój wiek:", wiek1, "lat")
wiek1 = str(wiek1)
print("Twój wiek: " + wiek1 + " lat")

nazwisko = "Kowalski"
pierwszyZnak = nazwisko[0]
print(pierwszyZnak)

dlugosc = len(nazwisko)
print("Dlugosc: ", dlugosc)

ostatniZnak = nazwisko[len(nazwisko)-1]
print("Ostatni znak: " ,ostatniZnak)

ostatniZnak = nazwisko[-1]
print("Ostatni znak: ", ostatniZnak)

#konwersja
x = "5"
print(type(x)) #str
x = int(x)
print(type(x)) #int

y = 10
print(type(y) #int
y = y/2
print(type(y) #5.0

nazwisko = "Kowalski"
print(nazwisko[0]) #k
print(nazwisko[0:3]) #kow
print(nazwisko[-2]) #k
print(nazwisko[-2:]) #ki
print(nazwisko[:-2]) #kowals
print(nazwisko[:-2:2]) #kwl co drugi znak bez ostatniego





print()

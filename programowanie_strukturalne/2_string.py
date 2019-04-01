tekst = "Anna, Pawel, Julia,"

lista = tekst.split(", ")
print(tekst)
print(lista)
print(type(lista)) #list

imie1 = lista[0]
print(imie1)

imieDuza = imie1.upper()
print(imieDuza) #ANNA

imieMale = imie1.lower()
print(imieMale) #anna

#sprawdzanie zawartosci
nazwisko = ""
print(nazwisko.isalpha()) #false

print("\n Podaj swoje nazwisko: ", end="")
nazwisko = input()
zawartosc = nazwisko.isalpha()
print(zawartosc) #wyswietli true/false, dla spacji tez false

text1 = "\nJulia\n"
text2 = "Nowak"
print(text1 +text2)

text1 = text1.rstrip() #usuwa znaki biale
print(text1 + text2)
print(text1 + " " + text2)

#wysiwetlanie lancucha znakow

#wszystkie wersje Pythona
text = "%s, Java i %s" % ("PHP", "Python")
print(text)

#nowsze wersje Pythona
text = "{1}, Java i {0}".format("PHP", "Python")
print(text)

#help(text.replace)

new = text.replace("PHP", "C#")
print(new)

#wypisanie danych
rok = 2019
miesiac = "kwiecien"
dzien = 1

print("\nData:", end="")
print(dzien, miesiac, rok)

print("\nData:", end="")
print(dzien, miesiac, rok, sep="-") #separator










print()

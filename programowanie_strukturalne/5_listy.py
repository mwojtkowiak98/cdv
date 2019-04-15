programowanie=['Python', 'C#', 'JS', 'PHP', 'JAVA']

print(programowanie)
print(type(programowanie))

pierwszy=programowanie[0]
print('pierwszy jezyk programowania: ' + pierwszy)

#trzyelementy=programowanie[0:3]
#print('trzy elementy: ' + trzyelementy)

ostatni=programowanie[-1]
print('ostatni jezyk programowania: ' + ostatni)

#dodanie nowego elementu do losujZlisty
programowanie.append('R')
print(programowanie)

#zliczanie el na liscie
ile=programowanie.count('Python')
print(f'Python wystepuje {ile} razy')

#ilosc elementow
#iloscElem=len(programowanie)
#print('Ilosc elementow w liscie' + iloscElem)

#łączenie list
print(f'\n\n{programowanie}')
inneJezyki=['c', 'c++']
print('polaczenie list')
programowanie.extend(inneJezyki)
print(programowanie)

#wyczyszczenie listy
nowa=programowanie
print(f'nowa lista: {nowa}')
nowa.clear()
print(f'nowa lista po wyczyszczeniu: {nowa}')
print(f'Lista programowanie po wyczyszczeniu: {programowanie}')

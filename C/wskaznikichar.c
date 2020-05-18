#include <stdio.h>
#include <stdlib.h>

void zamien(char *tekst)
{
	int i=0;
	for(i=0; tekst[i]!=0; i++);
	printf("liczba znakow tekstu %d\n", i);
	
	char *koniec, temp;
	while(*tekst!=' ' && *tekst!=0)
	{
		tekst++;
	}
	tekst++; //zeby wskazalo na "p"
	printf("wskaznik poczatku%c\n", *tekst);
	
	koniec=tekst;
	
	while(*koniec!=' ' && *koniec!=0)
	{
		koniec++;
	}
	koniec--; //cofniecie  o 1 wyraz do literki A
	i=(koniec-tekst+1)/2;
	
	for( ; i>0; i--)
	{
		temp=*tekst;
		*tekst=*koniec;
		*koniec=temp;
		
		tekst++;
		koniec--;
	}
}

int main()
{
char tekst[]="KURS PROGRAMOWANIA C";

zamien(tekst);
printf("%s\n", tekst);
	
	
	return 0;
}

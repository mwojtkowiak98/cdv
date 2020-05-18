#include <stdio.h>
#include <stdlib.h>

void modyfikuj(int *tab)
{
	printf("wskaznik pierwszej tab wynosi: %d\n", tab);
	printf("wartosc pierwszej tab wynosi: %d\n", *tab);
}



int main()
{
	
	int tab[]={1,5,9};
	
	//printf("tutaj %d\n", tab);
	
	modyfikuj(&tab);
	
	
	return 0;
}

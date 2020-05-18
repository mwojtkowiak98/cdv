#include <stdio.h>


	void efekttrucizny(int *h)
	{
		*h-=5;
	}


int main()
{
	int k=15;
	
	printf("%d", k);
	printf("\n");
	
	printf("adres zmiennej k wynosi: %d\n", &k);
	printf("\n");
	
	int *wskaznikk = &k;
	
	printf("adres zmiennej k wynosi: %d\n", wskaznikk);
	printf("\n");
	
	int hp=100;
	efekttrucizny(&hp);
	printf("Hp wynosi %d\n", hp);
	
	
	
	return 0;
}

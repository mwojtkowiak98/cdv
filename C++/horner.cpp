#include<iostream>
#include<cstdlib>
using namespace std;

int horner(int wsp[], int st, int x)
{
	if(st==0)
		return wsp[0];
	
	return x*horner(wsp,st-1,x)+wsp[st];
}


int main()
{

	
	int stopien, argument, i=0;
	int wspolczynniki[stopien+1];
		
	cout<<"Podaj stopien wielomianu: ";
	cin>>stopien;	
	
	if(stopien<0)
	{
		cout<<"Podaj liczbe naturalna!"<<endl;
	    main();
		cin.clear();
		cin.sync();
	}
		cin.clear();
		cin.sync();
	
	if(!stopien)
	{
		cout<<"Podaj liczbe naturalna!"<<endl;
		main();
		cin.clear();
		cin.sync();
	}
		cin.clear();
		cin.sync();

	for(i=0;i<stopien;i++)
	{
		cout<<"Podaj wspolczynnik dla potegi "<<stopien-i<<": ";
		if(!(cin>>wspolczynniki[i]))
		{
		cout<<"BLAD! nastepnym razem wpisz liczbe!"<<endl<<endl;
		}
		
	}
	cout<<"Podaj wartosc wyrazu wolnego: ";
	if(!(cin>>wspolczynniki[i]))
	{
		cout<<"BLAD! nastepnym razem wpisz liczbe!"<<endl<<endl;
	}
	
	cout<<"Podaj argument: ";
	if(!(cin>>argument))
	{
		cout<<"BLAD! nastepnym razem wpisz liczbe!"<<endl<<endl;
	}
	
	
	cout<<"W( "<<argument<<" ) = "<<horner(wspolczynniki,stopien,argument)<<endl;
	

	
	system("PAUSE");
	return 0;

}

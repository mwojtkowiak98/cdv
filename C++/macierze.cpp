#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	long long int wiersze1, wiersze2, kolumny1, kolumny2;
	long long int i=0, j=0, k=0, l=0, m=0, n=0, o=0;
	
	cout<<"Program do mnozenia macierzy"<<endl<<endl;
	
	cout<<"Podaj liczbe wierszy pierwszej macierzy: ";
	cin>>wiersze1;
		if(!wiersze1 || wiersze1<=0)
		{
			cout<<"BLAD, nastepnym razem podaj liczbe naturalna ( wieksza od 0 )"<<endl;
			return 0;
		}
	
	cout<<"Podaj liczbe kolumn pierwszej macierzy: ";
	cin>>kolumny1;
	cout<<endl;
		if(!kolumny1 || kolumny1<=0)
		{
		cout<<"BLAD, nastepnym razem podaj liczbe naturalna ( wieksza od 0 )"<<endl;
		return 0;
		}
	
	cout<<"Podaj liczbe wierszy drugiej macierzy: ";
	cin>>wiersze2;
		if(!wiersze2 || wiersze2<=0)
		{
		cout<<"BLAD, nastepnym razem podaj liczbe naturalna ( wieksza od 0 )"<<endl;
		return 0;
		}
	
	cout<<"Podaj liczbe kolumn drugiej macierzy: ";
	cin>>kolumny2;
	cout<<endl;
		if(!kolumny2 || kolumny2<=0)
		{
		cout<<"BLAD, nastepnym razem podaj liczbe naturalna ( wieksza od 0 )"<<endl;
		return 0;
	}
		
	int macierz1[wiersze1][kolumny1];
	int macierz2[wiersze2][kolumny2];
	int macierz3[wiersze1][kolumny2];
	
	
	
	
	for(i=0;i<wiersze1;i++)
	{
		for(j=0;j<kolumny1;j++)
		{
			cout<<"Podaj wartosci dla macierzy nr1 "<<i<<"."<<j<<" :";
			if(!(cin>>macierz1[i][j]))
			{
				cout<<"\nBLAD, nastepnym razem podaj liczbe calkowita"<<endl;
				return 0;
			}
			
			
		}
	}
	cout<<endl;
	
	for(k=0;k<wiersze2;k++)
	{
		for(l=0;l<kolumny2;l++)
		{
			cout<<"Podaj wartosci dla macierzy nr2 "<<k<<"."<<l<<" :";
			if(!(cin>>macierz2[k][l]))
			{
				cout<<"\nBLAD, nastepnym razem podaj liczbe calkowita"<<endl;
				return 0;
			}
						
		}
	}
	cout<<endl;
	
	cout<<"Macierz nr1: "<<endl;
	
	for(i=0;i<wiersze1;i++)
	{
		for(j=0;j<kolumny1;j++)
		{
			cout<<macierz1[i][j];
		}
		cout<<endl;
	}
	cout<<endl;
	
	cout<<"X"<<endl<<endl;
	
	cout<<"Macierz nr2: "<<endl;
	
	for(k=0;k<wiersze2;k++)
	{
		for(l=0;l<kolumny2;l++)
		{
			cout<<macierz2[k][l];
		}
		cout<<endl;
	}
	cout<<endl;
	
	cout<<"="<<endl<<endl;
	

	for(i=0;i<wiersze1;i++)
	{
   		for(j=0;j<kolumny2;j++)
    	{
      		int s=0;
     		for(k=0;k<kolumny1;k++) s+=macierz1[i][k] * macierz2[k][j];
      		macierz3[i][j]=s;
    	}
	}	

 
  	cout<<"Macierz nr3 = macierz nr1 x macierz nr2 || jej wymiary to: "<<wiersze1<<"x"<<kolumny2<<endl;

	for(i=0;i<wiersze1;i++)
	{
    		for(j=0;j<kolumny2;j++)
   		
			cout<<macierz3[i][j]<<" ";
    		cout<<endl;
  		
	}
	
	system("PAUSE");
	return 0;
}

#include<iostream>
#include<stdlib.h>
#include<conio.h>
#include<string>
using namespace std;

string kata;
string pal="";
int n,i;
bool palindrome = true;

void stack()
{
	system("cls");
	cout<<"Cek Kata Palindrome C++"<<endl;
	cout<<"======================="<<endl;
	cout<<"Masukan Kata = ";getline(cin,kata);
	n = kata.length();
	for (i=0; i<n; i++)
	{
		if (kata[i]!=kata[n-i-1])
		{
			palindrome = false;
			break;
		}
	}
	cout<<"Result = ";
	if (palindrome == true)
	cout<<"Palindrome True";
	else
	cout<<"Palindrome False";
	cin.ignore();
}
int main()
{	
	stack();
	return 0 ;
	getch();
}

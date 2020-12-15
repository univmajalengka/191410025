#include<iostream>
#include<string>
#include<stdlib.h>
#include<conio.h>
using namespace std;

int main ()
{
	mulai:
	system("cls");
	int ribuan, ratusan, puluhan, satuan, x,input;
	int milyaran,rtsJutaan,plhJutaan,Jutaan,rtsRibuan,plhRibuan;
	string milyaran1;
	char mt;

	cout<<"Pencacah Bilangan C++"<< endl;
	cout<< "Masukan Nilai = " ;cin >> x;
	if (x>=10000000000)
	{
		cout<<"MAx 10 digit"<<endl;
		cout<<"ERRORR"<<endl;
	}
	else
	{
		input = x/10000000000;
		milyaran =(x- input*10000000000)/1000000000;
		rtsJutaan =(x-input*10000000000-milyaran*1000000000)/100000000;
		plhJutaan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000)/10000000;
		Jutaan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000)/1000000;
		rtsRibuan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000-Jutaan*1000000)/100000;
		plhRibuan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000-Jutaan*1000000-rtsRibuan*100000)/10000;
		ribuan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000-Jutaan*1000000-rtsRibuan*100000-plhRibuan*10000)/1000;
		ratusan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000-Jutaan*1000000-rtsRibuan*100000-plhRibuan*10000-ribuan*1000)/100;
		puluhan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000-Jutaan*1000000-rtsRibuan*100000-plhRibuan*10000-ribuan*1000-ratusan*100)/10;
		satuan =(x-input*10000000000-milyaran*1000000000-rtsJutaan*100000000-plhJutaan*10000000-Jutaan*1000000-rtsRibuan*100000-plhRibuan*10000-ribuan*1000-ratusan*100-puluhan*10)/1;
		cout<<""<<endl;
		cout<< "Hasil Cacahan : " << endl;
		cout << milyaran <<  "000000000" <<endl;
		cout << rtsJutaan << "00000000" <<endl;
		cout << plhJutaan << "0000000" <<endl;
		cout << Jutaan   <<  "000000" <<endl;
		cout << rtsRibuan<<  "00000" <<endl;
		cout << plhRibuan<<  "0000" <<endl;
		cout << ribuan   <<  "000" <<endl;
		cout << ratusan  <<  "00" <<endl;
		cout << puluhan  <<  "0" <<endl;
		cout << satuan   <<  "" <<endl;
	}
 	ulang:
 	cout<<""<<endl;
 	cout<<"Apakah Anda Ingin Ulang (Y/T) ? = ";cin>>mt;
 	if(mt=='Y'||mt=='y')
 	{goto mulai;}
 	if(mt=='T'||mt=='t')
 	{goto selesai;}
 	else
 	{goto ulang;}
 	selesai:
 	cout<<""<<endl;
 	cout<<"==============TERIMA KASIH=============="<<endl;
	getch();
}

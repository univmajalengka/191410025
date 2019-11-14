#include<iostream.h>
#include<conio.h>

main()
{
char pilih;
char yt;
float lp,lpp,lr,ls,s1,l,p,r,a,t;

mulai:
clrscr();
cout<<"=============== HITUNG MATEMATIKA ==============="<<endl;
cout<<"================================================="<<endl;
cout<<"     Pilih Nomor"<<endl;
cout<<"     1. Luas Persegi           3. Luas P Panjang "<<endl;
cout<<"     2. Luas Lingkaran         4. Luas Segitiga  "<<endl;
cout<<"================================================="<<endl;
plh:
cout<<"Pilihan Kamu = ";cin>>pilih;
if (pilih=='1')
{goto persegi;}
if (pilih=='3')
{goto ppanjang;}
if (pilih=='2')
{goto lingkaran;}
if (pilih=='4')
{goto segitiga;}
else
cout<<"Pilihan 1     s/d    4 "<<endl;
{goto plh;}
persegi:
cout<<""<<endl;
cout<<"Hitung Luas Persegi"<<endl;
cout<<"==================="<<endl;
cout<<"Sisi         = " ;cin>>s1;
lp=s1*s1;
cout<<"Luasnya      = "<<lp<<endl;
cout<<""<<endl;
{goto ulang;}
ppanjang:
cout<<""<<endl;
cout<<"Hitung Luas Persegi Panjang"<<endl;
cout<<"==========================="<<endl;
cout<<"Panjang      = " ;cin>>p;
cout<<"Lebar        = " ;cin>>l;
lpp=p*l;
cout<<"Luasnya      = "<<lpp<<endl;
cout<<""<<endl;
{goto ulang;}
lingkaran:
cout<<""<<endl;
cout<<"Hitung Luas Lingkaran"<<endl;
cout<<"====================="<<endl;
cout<<"Jari-Jari   = ";cin>>r;
lr=3.14*r*r;
cout<<"Luasnya     = "<<lr<<endl;
cout<<""<<endl;
{goto ulang;}
segitiga:
cout<<""<<endl;
cout<<"Hitung Luas Segitiga"<<endl;
cout<<"===================="<<endl;
cout<<"Alas      = " ;cin>>a;
cout<<"Tinggi    = " ;cin>>t;
ls=a*t/2;
cout<<"Luas      = "<<ls<<endl;
cout<<""<<endl;
{goto ulang;}
ulang:
cout<<"Apakah Anda Ingin Ulang (Y/T) ? = ";cin>>yt;
if (yt=='Y'||yt=='y')
{goto mulai;}
if (yt=='T'||yt=='t')
{goto selesai;}
else
cout<<"Pilihan Hanya Y atau T"<<endl;
{goto ulang;}
selesai:
cout<<"=======Terima Kasih========="<<endl;

getch();
}

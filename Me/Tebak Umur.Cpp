//compiler using Borland C++ 5.02
#include<iostream.h>
#include<conio.h>

main()
{
char yt ;
char nama[30];
char npm[30] ;
int umur ;

mulai:
clrscr();
cout<<"================================================="<<endl;
cout<<"================== TEBAK UMUR ==================="<<endl;
cout<<"================================================="<<endl;
cout<<""<<endl;
cout<<"Masukan Nama Kamu = ";cin>>nama;
cout<<"Masukan NPM       = ";cin>>npm;
cout<<"Sekarang"<<endl;
cout<<"Umur Kamu         = ";cin>>umur;
cout<<""<<endl;
if (umur<=15)
{goto kecil;}
if (16<=umur&&umur<=40)
{goto sedang;}
if (umur>=41)
{goto tua;}
kecil:
cout<<"Hasil:"<<endl;
cout<<"Umur Kamu   = "<<umur<<" Tahun"<<endl;
cout<<"Kamu Masih Muda"<<endl;
cout<<""<<endl;
{goto ulang;}
sedang:
cout<<"Hasil:"<<endl;
cout<<"Umur Kamu   = "<<umur<<" Tahun"<<endl;
cout<<"Kamu Usia Pertengahan"<<endl;
cout<<"Atau Berada Dalam Golongan Om-OM"<<endl;
cout<<""<<endl;
{goto ulang;}
tua:
cout<<"Hasil:"<<endl;
cout<<"Umur Kamu   = "<<umur<<" Tahun"<<endl;
cout<<"Kamu Udah Tua"<<endl;
cout<<"Udah Kakek-Kakek"<<endl;
cout<<""<<endl;
{goto ulang;}
ulang:
cout<<"Kamu Ingin Ulang (Y/T) ? =";cin>>yt;
if (yt=='Y'||yt=='y')
{goto mulai;}
if (yt=='T'||yt=='t')
{goto selesai;}
selesai:
cout<<""<<endl;
cout<<"=================== TERIMA KASIH =================="<<endl;

getch();
}

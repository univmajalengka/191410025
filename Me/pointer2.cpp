#include<iostream.h>
#include<conio.h>

main()
{
int x ;
int y;
int z;
int *ptr;
int *prt;
int *rpt;
char mt;

mulai:
clrscr();
ptr = &x;
prt = &y;
rpt = &z;
cout<<"=======PROGRAM CONVERSI BILANGAN POINTER======="<<endl;
cout<<"==============================================="<<endl;
cout<<""<<endl;
cout<<"Masukan Bilangan1  = ";cin>>x;
cout<<"Masukan Bilangan2  = ";cin>>y;
cout<<"Masukan Bilangan3  = ";cin>>z;
cout<<""<<endl;
cout<<"==============================================="<<endl;
cout<<""<<endl;
cout<<""<<endl;
cout<<"=============HASIL================"<<endl;
cout<<"====Bilangan====   ====Pointer===="<<endl;
cout<<""<<endl;
cout<<"      "<<x<<"             "<<ptr<<endl;
cout<<"      "<<y<<"             "<<prt<<endl;
cout<<"      "<<z<<"             "<<rpt<<endl;
cout<<""<<endl;
cout<<"================================="<<endl;
cout<<""<<endl;
cout<<"Apakah Anda Ingin Ulang (Y/T) ? = ";cin>>mt;
if(mt=='Y'||mt=='y')
{goto mulai;}
if(mt=='T'||mt=='t')
{goto selesai;}
selesai:
cout<<""<<endl;
cout<<"===========TERIMA KASIH========="<<endl;

getch();
}
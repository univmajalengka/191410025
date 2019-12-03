#include<iostream.h>
#include<conio.h>

main()
{
float hg,jm,by,tt,kb;
char barang[30];
char yt;

mulai:
clrscr();
cout<<"=================KASIR================="<<endl;
cout<<"========Sangat Sederhana Sekali========"<<endl;
cout<<""<<endl;
cout<<"Nama Barang           = " ;cin>>barang;
cout<<"Harga Barang          = " ;cin>>hg;
cout<<"Jumlah Pembelian      = " ;cin>>jm;
cout<<""<<endl;
tt=hg*jm;
cout<<"======================================="<<endl;
cout<<"Total Bayar           = "<<tt<<endl;
cout<<"Uang Anda             = " ;cin>>by;
kb=by-tt;
cout<<"Kembalian             = "<<kb<<endl;
cout<<""<<endl;
cout<<"==============TERIMA KASIH============="<<endl;
cout<<""<<endl;
ulang:
cout<<"Apakah Anda Ingin Ulang (Y/T) ? = ";cin>>yt;
if(yt=='Y'||yt=='y')
{goto mulai;}
if(yt=='T'||yt=='t')
{goto selesai;}
else
cout<<"Pilihan Hanya Y atau T"<<endl;
{goto ulang;}
selesai:
cout<<""<<endl;
cout<<"======Silahkan Berkunjung Kembali======"<<endl;

getch();
}


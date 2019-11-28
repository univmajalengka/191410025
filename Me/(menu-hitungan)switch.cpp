#include<iostream.h>
#include<conio.h>
int main()
{
char yt,pilih;
float nilai1,nilai2,tbh,krng,bg,kl;
  mulai:
  clrscr();
  cout<<"====== Program Bilangan C++ ======"<<endl;
  cout<<"=================================="<<endl;
  cout<<"MENU UTAMA"<<endl;
  cout<<"1. Pertambahan"<<endl;
  cout<<"2. Pengurangan"<<endl;
  cout<<"3. Perkalian  "<<endl;
  cout<<"4. Pembagian  "<<endl;
  cout<<""<<endl;
  cout<<"Silahkan Pilih 1 / 4 = ";cin>>pilih;
  switch(pilih)
  {
  case '1':
  cout<<""<<endl;
  cout<<"MENU PERTAMBAHAN"<<endl;
  cout<<"Nilai 1      = ";cin>>nilai1;
  cout<<"Nilai 2      = ";cin>>nilai2;
  tbh=nilai1+nilai2;
  cout<<"HASILNYA     = "<<tbh<<endl;
  cout<<""<<endl;
  break;
  case '2':
  cout<<""<<endl;
  cout<<"MENU PENGURANGAN"<<endl;
  cout<<"Nilai 1      = ";cin>>nilai1;
  cout<<"Nilai 2      = ";cin>>nilai2;
  krng=nilai1-nilai2;
  cout<<"HASILNYA     = "<<krng<<endl;
  cout<<""<<endl;
  break;
  case '3':
  cout<<""<<endl;
  cout<<"MENU PERKALIAN"<<endl;
  cout<<"Nilai 1      = ";cin>>nilai1;
  cout<<"Nilai 2      = ";cin>>nilai2;
  kl=nilai1*nilai2;
  cout<<"HASILNYA     = "<<kl<<endl;
  cout<<""<<endl;
  break;
  case '4':
  cout<<""<<endl;
  cout<<"MENU PEMBAGIAN"<<endl;
  cout<<"Nilai 1      = ";cin>>nilai1;
  cout<<"Nilai 2      = ";cin>>nilai2;
  bg=nilai1/nilai2;
  cout<<"HASILNYA     = "<<bg<<endl;
  cout<<""<<endl;
  break;
  default:
  cout<<""<<endl;
  cout<<"===Pilihan Hanya 1/2/3/4==="<<endl;
  break;
  }
  ulang:
  cout<<"Apakah Anda Ingin Ulang (Y/T) ? = ";cin>>yt;
  if (yt=='Y'||yt=='y')
  {goto mulai;}
  if (yt=='T'||yt=='t')
  {goto selesai;}
  else
  cout<<""<<endl;
  cout<<"=Pilihan Hanya Y atau T="<<endl;
  {goto ulang;}
  selesai:
  cout<<"=======Terima Kasih========="<<endl;
  getch();
}

Program Array_2Dimensi;
uses crt;
type
daftarNamaBuah = array [1..3] of string[20];
daftarHargaPerKg = array [1..3, 'A'..'C'] of real;
const
Buah : daftarNamaBuah = ('Jambu','Salak','Mangga');
hargaPerKg : daftarHargaPerKg = ((1000, 800, 500),
                                 (3000,2000,1500),
                                 (2500,2000,1000));
var
noBuah : byte;
kg, TotalHarga : Real;
Kual,jawab : char;
Begin
repeat
clrscr;
textcolor(12);
writeln('================ Nama Buah Yang Tersedia ================');
writeln('=========================================================');
for noBuah := 1 to 3 do
writeln(noBuah:2,'. ',Buah[noBuah]);
writeln;
textcolor(11);
write  ('Nomor Pilihan Anda (1/2/3) : ');readln(noBuah);
write  ('Kualitas (A/B/C) ? ');readln(Kual);
Kual := Upcase (Kual);
write  ('Bearapa KG ? ');readln(kg);
TotalHarga := kg * hargaPerKg[noBuah, Kual];
writeln;
writeln('Anda Telah Memilih Buah  = ',Buah [noBuah]);
writeln('Dengan Kualitas          = ',Kual);
writeln('Harga Per KG             = ',hargaPerKg[noBuah, Kual] : 2:2,' Rupiah');
writeln('Total Harga              = ',TotalHarga :2:2,' Rupiah');
writeln;
textcolor(13);
write  ('Apakah Kamu Ingin Mengulang (A-Z/T)  : ');readln(jawab);
until (jawab in ['T','t']);
writeln('==================== Terima Kasih =======================');
readln;
end.

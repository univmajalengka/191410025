//Using Arduino Uno R3 ATmega328p
//Using DS3231 RTC
//Using MicroSD
//Using SimpleTimer Library
#include <SimpleTimer.h>
#include <DS3231.h>
#include <SPI.h>
#include <SD.h>
SimpleTimer timer;
DS3231  rtc(SDA, SCL);//(SD A4)(SC A5)//
File myFile;
int led1 = 7;
int led2 = 8;
String hari,tanggal,waktu;
void setup() {
  // put your setup code here, to run once:
timer.setInterval(1000L, real_time);
Serial.begin(9600);
rtc.begin();
pinMode (led1, OUTPUT);
pinMode (led2, OUTPUT);
Serial.println();
Serial.println("Buka file di kartu microSD");
if (!SD.begin(4))//int adalah untuk pin chip MikroSD//
{
 Serial.println("Failed!");
 Serial.println("Timer_Not_Starting");
 Serial.println(); 
 return;
}
Serial.println("Sukses microSD!");
myFile = SD.open("Output.txt", FILE_WRITE);
Serial.println("Time_Starting");
myFile.println("Timer_Starting");
}

void real_time()
{
  if (myFile)
  {
  digitalWrite(led1, HIGH);
  digitalWrite(led2, LOW);
  hari = rtc.getDOWStr();
  Serial.print(hari);
  myFile.print(hari);
  tanggal = rtc.getDateStr();
  Serial.print(" ");
  Serial.print(tanggal);
  Serial.print(" -- ");
  myFile.print(" ");
  myFile.print(tanggal);
  myFile.print(" -- ");
  waktu = rtc.getTimeStr();
  Serial.println(waktu);
  myFile.println(waktu);
  delay(1000);
  
  digitalWrite(led1, LOW);
  digitalWrite(led2, HIGH);
  hari = rtc.getDOWStr();
  Serial.print(hari);
  myFile.print(hari);
  tanggal = rtc.getDateStr();
  Serial.print(" ");
  Serial.print(tanggal);
  Serial.print(" -- ");
  myFile.print(" ");
  myFile.print(tanggal);
  myFile.print(" -- ");
  waktu = rtc.getTimeStr();
  Serial.println(waktu);
  myFile.println(waktu);
  delay(1000);
  }
  else
  {
    Serial.println("No_Device");
    Serial.println("Lampu Merah Nyala");
    Serial.println("Lampu Hijau Mati");
    Serial.println("");
    delay(1000);
    Serial.println("No_Device");
    Serial.println("Lampu Merah Mati");
    Serial.println("Lampu Hijau Nyala");
    Serial.println();
    delay(1000);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
timer.run();
}

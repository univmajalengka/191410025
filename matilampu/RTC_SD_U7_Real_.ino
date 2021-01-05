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
int led1 = 9;
int led2 = 6;
int led3 = 3;
String hari,tanggal,waktu;
String result;
int detik;
int ledRl;
char data;
void setup() {
  // put your setup code here, to run once:
timer.setInterval(1000L, led);
Serial.begin(9600);
pinMode (led1, OUTPUT);
pinMode (led2, OUTPUT);
pinMode (led3, OUTPUT);
Serial.println();
Serial.println("Buka file di kartu microSD");
if (!SD.begin(10))//int adalah untuk pin chip MikroSD//
{
 Serial.println("SD Not_Starting");
 analogWrite(led3, 100);
 ledRl=0;
 return;
}
rtc.begin();
hari = rtc.getDOWStr();
tanggal = rtc.getDateStr();
waktu = rtc.getTimeStr();
result = String(hari)+" -- " + tanggal + " -- " + waktu;
myFile = SD.open("LOGMODUL.TXT", FILE_WRITE);
myFile.println("Device is Starting");
myFile.println("=== Bismillah ===");
myFile.println(result);
myFile.println("");
myFile.close();
Serial.println("Sukses microSD!");
Serial.println();
delay(1000);
detik=1;
ledRl =1;
}

void led()
{
  if (ledRl==1)
  {
    analogWrite(led1, 100);
    digitalWrite(led2, LOW);
    delay(500);
    analogWrite(led2, 100);
    digitalWrite(led1, LOW);
    delay(500);
  }
  else
  {
    analogWrite(led3, 100);
  }
  
}

void bacaFile()
{
while(Serial.available()>0)
{
  data = Serial.read();
  if (data == 'A')
  {
    myFile=SD.open("LOGMODUL.txt");
    if (myFile)
    {
      while(myFile.available())
      {
        Serial.write(myFile.read());
      }
      myFile.close();
    }
    else
    {
      Serial.println("Gagal!");
    }
  }
}
}

void loop() {
  // put your main code here, to run repeatedly:
timer.run();
bacaFile();
}

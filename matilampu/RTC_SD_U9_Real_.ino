//Using Arduino Uno R3 ATmega328p
//Using DS3231 RTC
//Using MicroSD
//Using SimpleTimer Library
#include <SimpleTimer.h>
#include <DS3231.h>
#include <SPI.h>
#include <SD.h>
#include <ACS712.h>
ACS712 sensor(ACS712_30A, A0);
SimpleTimer timer;
DS3231  rtc(SDA, SCL);//(SD A4)(SC A5)//
File myFile;
int led1 = 9;
int led2 = 6;
int led3 = 3;
String hari,tanggal,waktu;
int detik;
char data;
float U;
void setup() {
  // put your setup code here, to run once:
timer.setInterval(1000L, real_time);
Serial.begin(9600);
pinMode (led1, OUTPUT);
pinMode (led2, OUTPUT);
pinMode (led3, OUTPUT);
Serial.println();
Serial.println("Buka file di kartu microSD");
if (!SD.begin(10))//int adalah untuk pin chip MikroSD//
{
 Serial.println("Timer_Not_Starting");
 return;
}
sensor.calibrate();
rtc.begin();
myFile = SD.open("MODULLOG.TXT", FILE_WRITE);
myFile.println("Device is Starting");
myFile.println("=== Bismillah ===");
myFile.close();
Serial.println("Sukses microSD!");
Serial.println();
delay(1000);
detik=1;
}

void real_time()
{
  float U = sensor.getCurrentAC();//Value Ampere meter
  if ((U >=0) and (U<=24))
  {
    myFile = SD.open("MODULLOG.TXT", FILE_WRITE);
    if (myFile)
    {
      detik +=1;
      if (detik ==1)
      {
        analogWrite(led1,10);
        digitalWrite(led2,LOW);
        myFile.print("Listrik Mati  : ");
        hari = rtc.getDOWStr();
        myFile.print(hari);
        tanggal = rtc.getDateStr();
        myFile.print(" ");
        myFile.print(tanggal);
        myFile.print(" -- ");
        waktu = rtc.getTimeStr();
        myFile.println(waktu);
        myFile.close();
      }
      else if(detik ==2)
      {
        digitalWrite(led1, LOW);
        analogWrite(led2, 10);
        hari = rtc.getDOWStr();
        myFile.print(hari);
        tanggal = rtc.getDateStr();
        myFile.print(" ");
        myFile.print(tanggal);
        myFile.print(" -- ");
        waktu = rtc.getTimeStr();
        myFile.println(waktu);
        myFile.close();
        detik =0;
      }
    }
    else
    {
      Serial.println("No_Device");
      analogWrite(led3, 50);
      digitalWrite(led1, LOW);
      digitalWrite(led2, LOW);
    }
  }
  else if (U >= 25)
  {
     myFile = SD.open("MODULLOG.TXT", FILE_WRITE);
    if (myFile)
    {
      detik +=1;
      if (detik ==1)
      {
        analogWrite(led1,10);
        digitalWrite(led2,LOW);
        myFile.print("Listrik Nyala  : ");
        hari = rtc.getDOWStr();
        myFile.print(hari);
        tanggal = rtc.getDateStr();
        myFile.print(" ");
        myFile.print(tanggal);
        myFile.print(" -- ");
        waktu = rtc.getTimeStr();
        myFile.println(waktu);
        myFile.close();
      }
      else if(detik ==2)
      {
        digitalWrite(led1, LOW);
        analogWrite(led2, 10);
        hari = rtc.getDOWStr();
        myFile.print(hari);
        tanggal = rtc.getDateStr();
        myFile.print(" ");
        myFile.print(tanggal);
        myFile.print(" -- ");
        waktu = rtc.getTimeStr();
        myFile.println(waktu);
        myFile.close();
        detik =0;
      }
    }
    else
    {
      Serial.println("No_Device");
      analogWrite(led3, 50);
      digitalWrite(led1, LOW);
      digitalWrite(led2, LOW);
    }
  }
    delay(1000);
}

void bacaFile()
{
while(Serial.available()>0)
{
  data = Serial.read();
  if (data == 'A')
  {
    myFile=SD.open("MODULLOG.txt");
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
  else if (data == 'B')
  {
    myFile=SD.open("About.txt");
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

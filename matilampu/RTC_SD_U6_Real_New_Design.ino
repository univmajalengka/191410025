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
int detik;
String result;
char data;
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
rtc.begin();
myFile = SD.open("LOGMODUL.TXT", FILE_WRITE);
myFile.println("                         Device is Starting                      ");
myFile.println("============================= Bismillah =========================");
myFile.println("====== Hari ======   ||   ==== Tanggal =====  || ==== Waktu =====");
myFile.close();
Serial.println("Sukses microSD!");
Serial.println();
delay(1000);
detik=1;
}

void real_time()
{
  myFile = SD.open("LOGMODUL.TXT", FILE_WRITE);
  if (myFile)
  {
    detik +=1;
    if (detik ==1)
    {
      analogWrite(led1,10);
      digitalWrite(led2,LOW);
      hari = rtc.getDOWStr();
      tanggal = rtc.getDateStr();
      waktu = rtc.getTimeStr();
      result = String("      ")+ hari + "        <-->      " + tanggal + "     <-->     " + waktu;
      myFile.println(result);
      myFile.close();
    }
    else if(detik ==2)
    {
      digitalWrite(led1, LOW);
      analogWrite(led2, 10);
      hari = rtc.getDOWStr();
      tanggal = rtc.getDateStr();
      waktu = rtc.getTimeStr();
      result = String("      ")+ hari + "        <-->      " + tanggal + "     <-->     " + waktu;
      myFile.println(result);
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
  delay(1000);
}

void bacaFile()
{
while(Serial.available()>0)
{
  data = Serial.read();
  if (data == 'A')
  {
    myFile=SD.open("LOGMODUL.TXT");
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

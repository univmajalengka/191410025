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
int led2 = 8;
int led3 = 4;
String hari,tanggal,waktu;
int detik;
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
myFile = SD.open("datalog.txt", FILE_WRITE);
myFile.println("Device is Starting");
myFile.println("=== Bismillah ===");
myFile.close();
Serial.println("Sukses microSD!");
delay(1000);
detik=1;
}

void real_time()
{
  myFile = SD.open("datalog.txt", FILE_WRITE);
  if (myFile)
  {
    detik +=1;
    if (detik ==1)
    {
      digitalWrite(led1,HIGH);
      digitalWrite(led2,LOW);
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
      digitalWrite(led2, HIGH);
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
    digitalWrite(led3, HIGH);
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
  }
  delay(1000);
}

void loop() {
  // put your main code here, to run repeatedly:
timer.run();
}

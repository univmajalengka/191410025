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
void setup() {
  // put your setup code here, to run once:
timer.setInterval(200L, lampu);
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
}

void real_time()
{
  myFile = SD.open("datalog.txt", FILE_WRITE);
  if (myFile)
  {
  timer.run();
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
  else
  {
    Serial.println("No_Device");
    digitalWrite(led3, HIGH);
  }
  delay(1000);
}
void lampu()
{
  digitalWrite(led1, HIGH);
  digitalWrite(led2, LOW);
  delay(200);
  digitalWrite(led1, LOW);
  digitalWrite(led2, HIGH);
  delay(200);
}

void loop() {
  // put your main code here, to run repeatedly:
real_time();
}

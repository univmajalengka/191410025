//NodeMCU Board
#define BLYNK_PRINT Serial
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
#include <SimpleTimer.h>
SimpleTimer timer, timer1;
String nilai;
int led1 = D2;
int led2 = D5;
int valua;
char auth[] = "Auth";
char ssid[] = "SSID";
char pass[] = "PASSWORD";

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
Blynk.begin(auth,ssid,pass);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
timer.setInterval(300L, image);
timer1.setInterval(300L, led);
}
void led()
{
  if (nilai == "1")
  {
    analogWrite(led1, valua);
    analogWrite(led2, valua);
    delay(300);
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    delay(300);
  }
  else if (nilai == "0")
  {
    
  }
}

BLYNK_WRITE (V1)
{
  nilai = param.asStr();//Nilai Untuk Pencabangan DateTime Blynk_APP
}

void image()
{
  Blynk.virtualWrite(V2,1);//Tampilkan Gambar Ke 1
  delay(300);
  Blynk.virtualWrite(V2,2);// Tampilkan Gambar Ke 2
  delay(300);
}

BLYNK_WRITE(V3)
{
  valua = param.asInt();//Nilai Analog Dinamis Untuk LedLight
}
void loop() {
  // put your main code here, to run repeatedly:
Blynk.run();
timer.run();
timer1.run();
}

#define BLYNK_PRINT Serial
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
#include <SimpleTimer.h>
SimpleTimer timerLed, timerImage;
int led1 = D1;
int led2 = D2;
int led3 = D5;
int led4 = D8;
int valueLed, valueLight; 
char auth[] = "Auth Dari Blynk";
char ssid[] = "SSID";
char pass[] = "PASSWORD";

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
Blynk.begin(auth,ssid,pass);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
pinMode(led4, OUTPUT);
timerLed.setInterval(100L, led);//Interval LED
timerImage.setInterval(100L, image); //Interval Gambar

}

BLYNK_WRITE(V1)
{
  valueLed = param.asInt();//nilai Untuk Joystik Jumlah Led Nyala
}

BLYNK_WRITE(V2)
{
  valueLight = param.asInt();//Kadar Terang Atau Tidaknya LED
}

void led()
{//Pencabangan Jumlah Nyala LED Berdasarkan Nilai Value Joystik
  if ((valueLed >=0) and (valueLed <= 25 ))
  {
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led4, LOW);
  }
  else if ((valueLed >=26) and (valueLed <= 50 ))
  {
    analogWrite(led1, valueLight);//Nilai Value Gelap atau Terangnya LED Secara Dinamis,,
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led4, LOW);
  }
  else if ((valueLed >=51) and (valueLed <= 75 ))
  {
    analogWrite(led1, valueLight);
    analogWrite(led2, valueLight);
    digitalWrite(led3, LOW);
    digitalWrite(led4, LOW);
  }
  else if ((valueLed >=76) and (valueLed <= 100 ))
  {
    analogWrite(led1, valueLight);
    analogWrite(led2, valueLight);
    analogWrite(led3, valueLight);
    digitalWrite(led4, LOW);
  }
    else if ((valueLed >=101) and (valueLed <= 125 ))
  {
    analogWrite(led1, valueLight);
    analogWrite(led2, valueLight);
    analogWrite(led3, valueLight);
    analogWrite(led4, valueLight);
  }
}

void image()
{
  Blynk.virtualWrite(V3, 1);//Animasi Gambar(UNMA)
  delay(200);
  Blynk.virtualWrite(V3, 2);//Animasi Gambar(Telkomsel)
  delay(200);
}
void loop() {
  // put your main code here, to run repeatedly:
Blynk.run();
timerLed.run();
timerImage.run();
}

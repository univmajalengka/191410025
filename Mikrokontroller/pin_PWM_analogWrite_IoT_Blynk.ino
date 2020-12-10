//nodeMcu ESP8266
#define BLYNK_PRINT Serial
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
int led1 = D1;
int led2 = D4;
int led3 = D5;
int led4 = D7;
//Karena Semua pin Di Board ini PWM
char auth[] = "Auth Dari Blynk App";
char ssid[] = "SSID";
char pass[] = "Password";
void setup() {
  // put your setup code here, to run once:
Blynk.begin(auth,ssid,pass);
Serial.begin(9600);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
pinMode(led4, OUTPUT);
}
BLYNK_WRITE(V1)
{
  nilai = param.asInt();
  analogWrite(led1, nilai);
  analogWrite(led2, nilai);
  analogWrite(led3, nilai);
  analogWrite(led4, nilai);
  Blynk.virtualWrite(V2, nilai);
}

void loop() {
  // put your main code here, to run repeatedly:
Blynk.run();
}

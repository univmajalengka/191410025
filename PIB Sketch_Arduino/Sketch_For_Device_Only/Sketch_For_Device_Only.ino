#include <SimpleTimer.h>
SimpleTimer timer1;
int pinMQ = A0;
int led1 = D7;
int led2 = D8;
int snd = D1;
int smoke,lpg;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(snd, OUTPUT);
pinMode(pinMQ, INPUT);
timer1.setInterval(1000L, smoker);
}

void smoker()
{
   smoke =analogRead(pinMQ);
   lpg = smoke / 12;
   if (smoke >= 550)
   {
    analogWrite(led1, 50);
    analogWrite(led2, 700);
    digitalWrite(snd, HIGH);
    delay(500);
    analogWrite(led1, 700);
    analogWrite(led2, 50);
    digitalWrite(snd, LOW);
    delay(500);
   }
   else if (smoke <= 550)
   {
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(snd, LOW);
   }
}

void loop() {
  // put your main code here, to run repeatedly:
timer1.run();
}

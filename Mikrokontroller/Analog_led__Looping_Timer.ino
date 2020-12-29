#include<SimpleTimer.h>
SimpleTimer timer;
int ledH = D5;
int ledB = D7;
char data;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(ledH, OUTPUT);
pinMode(ledB, OUTPUT);
timer.setInterval(200L, Check);
}

void trans()
{
  while(Serial.available()>0)
  {
    data = Serial.read();
  }
}

void Check()
{
  if (data == 'A')
  {
    analogWrite(ledH, 700);
    analogWrite(ledB, 20);
    delay(600);
    analogWrite(ledH, 20);
    analogWrite(ledB, 700);
    delay(600);
    Serial.print("Input = ");
    Serial.println(data);
  }
  else if (data == 'B')
  {
    analogWrite(ledH, 700);
    analogWrite(ledB, 20);
    delay(200);
    analogWrite(ledH, 20);
    analogWrite(ledB, 700);
    delay(200);
    Serial.print("Input = ");
    Serial.println(data);
  }
}
void loop() {
  // put your main code here, to run repeatedly:
trans();
timer.run();
}

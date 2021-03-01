#include <SimpleTimer.h>
SimpleTimer timer;
int led1 = D2;
int led2 = D5;
int led3 = D8;
char data;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
timer.setInterval(50L, led);
}

void sendSerial()
{
  while(Serial.available()>0)
  {
    data = Serial.read();
  }
}

void led()
{
  if (data == 'A')
  {
    digitalWrite(led1, HIGH);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
  }
  else if (data == 'B')
  {
    digitalWrite(led2, HIGH);
    digitalWrite(led1, HIGH);
    digitalWrite(led3, LOW);
  }
  else if (data == 'C')
  {
    digitalWrite(led3, HIGH);
    digitalWrite(led2, HIGH);
    digitalWrite(led1, HIGH);
  }
  else if (data == 'D')
  {
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
sendSerial();
timer.run();
}

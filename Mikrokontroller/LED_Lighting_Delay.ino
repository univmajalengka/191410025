#include <SimpleTimer.h>
SimpleTimer timer;
int led1 = D2;
int led2 = D5;
int led3 = D8;
int i;
char data;
void setup() {
  // put your setup code here, to run once:
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
Serial.begin(9600);
timer.setInterval(5L, led);
}

void SendSerial()
{
  while(Serial.available()>0)
  {
    data = Serial.read();
  }
}

void led()
{
  if(data == 'A')
  {
   for (i=0; i<=500 ;i+=1)
    {
      analogWrite(led1, i);
      analogWrite(led2, i);
      analogWrite(led3, i);
      delay(5);
    }
    for (i=500; i>=0; i-=1)
    {
      analogWrite(led1, i);
      analogWrite(led2, i);
      analogWrite(led3, i);
      delay(5);
    }
  }
  else
  {

  }
}

void loop() {
  // put your main code here, to run repeatedly:
  SendSerial();
timer.run();
}

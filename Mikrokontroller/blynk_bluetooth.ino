//Using NodeMcuBoard
#define BLYNK_PRINT Serial
#include <BlynkSimpleSerialBLE.h>
#include <SimpleTimer.h>
SimpleTimer timer;
char auth[] = "Your Auth";
int led1 = D2;
int led2 = D5;
int led3 = D8;
int light;

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
Blynk.begin(Serial, auth);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
timer.setInterval(200L, led);
}

BLYNK_WRITE(V1)
{
  if (param.asInt()==1)
  {
    light = 1;
  }
  else
  {
    
  }
}

BLYNK_WRITE(V2)
{
  if (param.asInt()==1)
  {
    light = 0;
  }
  else
  {
    
  }
}

BLYNK_WRITE(V3)
{
  if (param.asInt()==1)
  {
    light = 3;
  }
  else
  {
    
  }
}

BLYNK_WRITE(V4)
{
  if (param.asInt()==1)
  {
    light =4;
  }
}

void led()
{
  if (light ==1)
  {
    digitalWrite(led1, HIGH);
    digitalWrite(led2, HIGH);
    digitalWrite(led3, HIGH);
  }
  else if (light ==0)
  {
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
  }
  else if (light == 3)
  {
    digitalWrite(led1, HIGH);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    delay(200);
    digitalWrite(led2, HIGH);
    digitalWrite(led1, LOW);
    digitalWrite(led3, LOW);
    delay(200);
    digitalWrite(led3, HIGH);
    digitalWrite(led2, LOW);
    digitalWrite(led1, LOW);
    delay(200);
  }
  else if (light ==4)
  {
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW); 
  }
}
void loop() {
  // put your main code here, to run repeatedly:
Blynk.run();
timer.run();
}

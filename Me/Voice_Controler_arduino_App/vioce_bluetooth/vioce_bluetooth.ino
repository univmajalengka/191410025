#include <SoftwareSerial.h>
SoftwareSerial mySerial(13,10);
int led1 = 2;
int led2 = 4;
void setup() {
  // put your setup code here, to run once:
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
Serial.begin(9600);
mySerial.begin(9600);
}
String data="";
void loop() {
  // put your main code here, to run repeatedly:
if(mySerial.available())
{
  data=mySerial.readString();
  Serial.println(data);
  if(data=="nyala")
  {
    digitalWrite(led1, HIGH);
  }
  else if (data =="gelap")
  {
    digitalWrite(led1, LOW);
  }
  if (data=="hidup")
  {
    digitalWrite(led2, HIGH);
  }
  else if (data=="mati")
  {
    digitalWrite(led2, LOW);
  }
}
}

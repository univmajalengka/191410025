#include <DHT.h>
#define DHTPIN 6
#define DHTTYPE DHT11
DHT dht(DHTPIN,DHTTYPE);
int led1 = 2;
int led2 = 3;
int led3 = 4;
char data;
void setup() {
  // put your setup code here, to run once:
dht.begin();
Serial.begin(9600);
pinMode (led1, OUTPUT);
pinMode (led2, OUTPUT);
pinMode (led3, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
int hum = dht.readHumidity();
int temp = dht.readTemperature();
Serial.print("H");
Serial.println(hum);
Serial.print("T");
Serial.println(temp);
delay(300);
if (Serial.available()>0)
{
  data = Serial.read();
  if (data == 'A')
  {
    digitalWrite(led1, HIGH);  
  }
  else if (data == 'a')
  {
    digitalWrite(led1, LOW);
  }
  if (data == 'B')
  {
    digitalWrite(led2, HIGH);
  }
  else if (data == 'b')
  {
    digitalWrite(led2, LOW);
  }
  if (data == 'C')
  {
    digitalWrite(led3, HIGH);
  }
  else if (data == 'c')
  {
    digitalWrite(led3, LOW);
  }
}
}

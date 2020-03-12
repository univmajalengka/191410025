#include <DHT.h>
#define DHTTYPE DHT11
#include <SoftwareSerial.h>
const int dhtpin = 51;
DHT dht(dhtpin, DHTTYPE);
int led = 52;
char data;
void setup() {
  // put your setup code here, to run once:
pinMode(led, OUTPUT);
dht.begin();
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int hum = dht.readHumidity();
  int temp = dht.readTemperature();
    Serial.print("H");
    Serial.println(hum);
    Serial.print("T");
    Serial.println(temp);
    delay(1000);
if(Serial.available()>0)
{
  data=Serial.read();
  Serial.println(data);
  if(data=='F')
  {
    digitalWrite(led, HIGH);
  }
  else if(data=='L')
  {
    digitalWrite(led, LOW);
  }
}
}

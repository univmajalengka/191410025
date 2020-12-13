#include <Wire.h>
#include <RtcDS3231.h>
RtcDS3231<TwoWire> Rtc(Wire);//SDA(pinD2) SCL(pinD1)

void setup()
{
  Serial.begin(9600);
  Rtc.Begin();
  RtcDateTime now = Rtc.GetDateTime();    
  Rtc.Enable32kHzPin(false);
  Rtc.SetSquareWavePin(DS3231SquareWavePin_ModeNone);
}

void loop()
{
    RtcDateTime now = Rtc.GetDateTime();
    Serial.print("Date:");
    Serial.print(now.Day());
    Serial.print('/');
    Serial.print(now.Month());
    Serial.print('/');
    Serial.print(now.Year());
    Serial.print(" Time:");
    Serial.print(now.Hour());
    Serial.print(':');
    Serial.print(now.Minute());
    Serial.print(':');
    Serial.println(now.Second());
    
    delay(1000);
}

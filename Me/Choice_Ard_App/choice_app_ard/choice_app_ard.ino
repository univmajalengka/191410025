int ledMerah = 4;
int ledHijau = 2;
char data;
void setup() {
  // put your setup code here, to run once:
pinMode(ledMerah, OUTPUT);
pinMode(ledHijau, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available()>0)
{
   data=Serial.read();
   if(data=='A')
   {
    digitalWrite(ledMerah, HIGH);
   }
   else if (data=='a')
   {
    digitalWrite(ledMerah, LOW);
   }
    else if (data=='B')
   {
    digitalWrite(ledHijau, HIGH);
   }
    else if (data=='b')
   {
    digitalWrite(ledHijau, LOW);
   }
}
}

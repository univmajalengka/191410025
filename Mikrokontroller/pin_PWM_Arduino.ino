int led1 = 3;
int led2 = 5;
int led3 = 6;
int led4 = 9;
//khusus pin PWM
char data;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
pinMode(led4, OUTPUT);
}
void first1()
{
  analogWrite(led1, 50);
  analogWrite(led2, 50);
  analogWrite(led3, 50);
  analogWrite(led4, 50);
}
void second1()
{
  analogWrite(led1, 200);
  analogWrite(led2, 200);
  analogWrite(led3, 200);
  analogWrite(led4, 200);
}
void arduino()
{
  while(Serial.available()>0)
  {
    data = Serial.read();
    if(data=='A')
    {
      first1();
    }
    else if(data == 'B')
    {
      second1();
    }
  }
}
void loop() {
  // put your main code here, to run repeatedly:
arduino();
}

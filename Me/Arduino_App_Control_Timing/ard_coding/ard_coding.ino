int led1 = 2;
int led2 = 4;
char data;
void setup() {
  // put your setup code here, to run once:
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available()>0)
{
  data = Serial.read();
  Serial.println(data);
  if (data == 'A')
  {
    digitalWrite(led1, HIGH);
  }
  else if (data == 'a')
  {
    digitalWrite(led1, LOW);
  }
  if (data=='B')
  {
    digitalWrite(led2, HIGH);
  }
  else if (data =='b')
  {
    digitalWrite(led2, LOW);
  }
}
}

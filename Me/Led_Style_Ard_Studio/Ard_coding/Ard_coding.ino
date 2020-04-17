int led1 = 2;
int led2 = 3;
int led3 = 4;
char data;
void setup() {
  // put your setup code here, to run once:
pinMode(led1, OUTPUT);
pinMode(led2, OUTPUT);
pinMode(led3, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
while (Serial.available()>0)
{
  data=Serial.read();
  Serial.println(data);
  if (data== 'A')
  {
    digitalWrite(led1, HIGH);
  }
  else if (data== 'a')
  {
    digitalWrite(led1, LOW);
  }
  if (data== 'B')
  {
    digitalWrite(led2, HIGH);
  }
  else if (data== 'b')
  {
    digitalWrite(led2, LOW);
  }
  if (data == 'C')
  {
    digitalWrite(led3, HIGH);
  }
  else if (data== 'c')
  {
    digitalWrite(led3, LOW);
  }
}
}

int ledH1 = D6;
int ledH2 = D8;
int ledB1 = D1;
int ledB2 = D2;
char data;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(ledH1, OUTPUT);
pinMode(ledH2, OUTPUT);
pinMode(ledB1, OUTPUT);
pinMode(ledB2, OUTPUT);
}

void comunication()
{
  while (Serial.available()>0)
  {
    data = Serial.read();
  }
}

void loop() {
  // put your main code here, to run repeatedly:
comunication();
process();
}

void process()
{
  if (data == 'A')
  {
    digitalWrite(ledB1, HIGH);
    digitalWrite(ledB2, HIGH);
  }
  else if (data == 'B')
  {
    digitalWrite(ledB1, LOW);
    digitalWrite(ledB2, LOW);
  }
  else if (data == 'C')
  {
    digitalWrite(ledH1, HIGH);
    digitalWrite(ledH2, HIGH);
  }
  else if (data == 'D')
  {
    digitalWrite(ledH1, LOW);
    digitalWrite(ledH2, LOW);
  }
}

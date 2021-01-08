const int trig = D7;
const int echo = D8;
//int ht = 16 ;
long duration,mm,mm1;
float gr;
int gram;
void setup() {
  // put your setup code here, to run once:
pinMode(trig, OUTPUT);
pinMode(echo, INPUT);
Serial.begin(9600);
//lcd.begin(16,2);
//ht = 16;
}

void loop() {
  // put your main code here, to run repeatedly:
ultrasonic();
}

void ultrasonic()
{
  digitalWrite(trig, LOW);
  delay(200);
  digitalWrite(trig,HIGH);
  delay(200);
  digitalWrite(trig,LOW);

  duration=pulseIn(echo, HIGH);

  mm = duration*0.34/2;//per miliMeter
  mm1 = mm-20;//Jarak Terdekat Ultrasonic dalam Pengukuran Awal 2 cm atau 20 mm
  //Jadi Kalau MIsalkan Jarak 20 mm,, Maka Itu Akan Dinilai 0 Gram,,
  gr = mm1 * 0.5;//tetapan Pegas Apabila Bertambah 1 mili Maka Bertambah 0.5 gram(dikalikan dengan 0.5)
  gram = gr;
  Serial.print("H");
  Serial.println(mm);
  Serial.print("T");
  Serial.println(gr);
  Serial.print("A");
  Serial.println(gram);
}

#include <SimpleTimer.h>
SimpleTimer timer;
char data;
int s;
int m;
int h;

void setup() 
{
  Serial.begin(9600);
  timer.setInterval(200L, send1);
  //timer.setInterval(1000L, send1);//Untuk Detik Yang Asli Gunakan ini,,
  
}
void send1()
{
  if (Serial.available()>0)
  data=Serial.read();
  if (data=='A')
  {
    s +=1;
    Serial.print("Jam  ");
    Serial.print(h);
    Serial.print("  :  ");
    Serial.print("Menit  ");
    Serial.print(m);
    Serial.print(" :  ");
    Serial.print("detik  ");
    Serial.println(s);
    if (s==59)
    {
      s=0;
      m+=1;
    }
    else if (m==59)
    {
      s=0;
      m=0;
      h+=1;
    }
    else if (h==24)
    {
      s=0;
      m=0;
      h=0;
    }
  }
  else if (data=='a')
  {
    
  }
}

void loop() 
{
  timer.run();
}

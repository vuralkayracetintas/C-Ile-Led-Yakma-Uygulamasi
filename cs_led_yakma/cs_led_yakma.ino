int Led1 = 5;
int Led2 = 6;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(Led1,OUTPUT);
  pinMode(Led2,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available())
  {
    char gelen_bilgi = Serial.read();
    if(gelen_bilgi=='1')
    {
      digitalWrite(Led1,HIGH);
      digitalWrite(Led2,HIGH);
    }
    else if (gelen_bilgi=='0')
    {
      digitalWrite(Led1,LOW);
      digitalWrite(Led2,LOW);
    }
  }
  delay(100);
}

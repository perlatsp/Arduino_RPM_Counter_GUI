/*
 * created by Perlat Kociaj, https://www.facebook.com/drperlat
 * Controlling LEDs with an Android App via Bluetooth
 */
 

int led = 13; 
int signal;
void setup()
{                
   
  pinMode(led, OUTPUT);          
  
  Serial.begin(9600);
}

void loop() 
{
  if(Serial.available() > 0)
  {   
    signal = Serial.read();
  
  }
   if(signal =='0')
    {
      digitalWrite(led, LOW);
    }  
    if (signal == '1') 
    {
      digitalWrite(led, HIGH);
    }  

    Serial.println(map(analogRead(A0),0,1023,0,360));
  delay(150);
}//loop()

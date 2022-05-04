#define LED 13

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  inputBuffer[5] = '\0';
}

int readI() {
      char buf[50];
      char c='\0';    
      int i = 0;
      while(c != '\n' && i < 50) {  
        if(Serial.available()) {     // nur lesen, wenn Daten da sind
          c = Serial.read(); // bis \n
          buf[i] = c;
          i++;
        }
      }
      buf[i - 1] = '\0';    // wir überschreiben \n mit \0
      return atoi(buf);
}

void loop() {
  // put your main code here, to run repeatedly:
  int input =readI();
  Serial.println(input);
  if(input > 0 && input <= 5000){
        digitalWrite(LED, HIGH);
        delay(input);
        digitalWrite(LED,LOW);
      }
}

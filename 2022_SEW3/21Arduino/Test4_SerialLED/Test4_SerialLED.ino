#define LED 13

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
}

int readI() {
      char inputbuffer[50];
      char c='\0';    
      int i = 0;
      while(c != '\n' && i < 50) {  
        if(Serial.available()) {     // nur lesen, wenn Daten da sind
          c = Serial.read(); // bis \n
          inputbuffer[i] = c;
          i++;
        }
      }
      inputbuffer[i - 1] = '\0';    // wir überschreiben \n mit \0
      return atoi(inputbuffer);
}

void loop() {
  // put your main code here, to run repeatedly:
  int input =readI();
  if(input > 0 && input <= 5000){
        digitalWrite(LED, HIGH);
        delay(input);
        digitalWrite(LED,LOW);
      }
}

#define LED_BUILTIN 13

void setup() {
  // put your setup code here, to run once:
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);
  Serial.println("---LED-Steuerung---");
  Serial.println("e: einschalten / a: ausschalten");
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    char eingabe = Serial.read();
    if(eingabe == 'e'){
      digitalWrite(LED_BUILTIN, HIGH);
      Serial.println("LED wurde eingeschaltet.");
    }
    else if(eingabe == 'a'){
      digitalWrite(LED_BUILTIN, LOW);
      Serial.println("LED wurde ausgeschaltet.");
    }
  }
}

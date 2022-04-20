#include "Wire.h"
#define Pin_LED 9

volatile byte value;

void setup() {
  // put your setup code here, to run once:
  Wire.begin(8);  // Es wird die Adresse 8 für den Slave festgelegt
  Wire.onReceive(dataReceived);
  pinMode(Pin_LED, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  analogWrite(Pin_LED, value);
}

void dataReceived(int Anzahl){
  if(Wire.available()){
    value = Wire.read();
  }
}

#include "Wire.h"  //Bibliothek für I2C
#define PIN_POTI 2

void setup() {
  // put your setup code here, to run once:
  Wire.begin(); // Master "hat" keine Adresse
}

void loop() {
  // put your main code here, to run repeatedly:
  int value = analogRead(PIN_POTI);
  // value 0-1024
  // I2C kann jedoch nur 8 bit
  value = value / 4;
  Wire.beginTransmission(8);  // Übertragung zu Slave mit Adresse 8
  Wire.write(value);
  Wire.endTransmission();
  delay(500);
}

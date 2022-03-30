#include <HCSR04.h>
#define TRIG_PIN 12
#define ECHO_PIN 11

int values[200];
int i = 0;
unsigned long lastOutput = millis();

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  HCSR04.begin(TRIG_PIN, ECHO_PIN);
}

void loop() {
  // put your main code here, to run repeatedly:
  /*double* distances = HCSR04.measureDistanceCm(); // wir bekommen ein Array als Rückgabewert
  Serial.print(distances[0]);
  Serial.println(" cm");
  delay(2000);*/

  if(millis() - lastOutput > 1000){
    double temp = 0;
    for(int j = 0; j < 200; j++){
      temp += values[j];
      values[j] = 0;
    }
    temp = temp / 200;
    Serial.println(temp);
    lastOutput = millis();
  }
  values[i] = HCSR04.measureDistanceCm();
  delay(5);
}

// alle 5 ms auslesen und in ein Array speichern
// alle Sekunden den gleitenden Mittelwert (der letzten Sekunde) auf die Serielle Schnittstelle schreiben.
